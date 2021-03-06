﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public int m_LvlNumber;
	public float m_StartDelay = 3f;
	public float m_EndDelay = 3f;
	public float m_HintDelay = 5f;
	public CameraControl m_CameraControl;
	public Text m_MessageText;
	public GameObject hint;
	public GameObject m_Pause;
	public GameObject[] m_PlayerPrefab;
	public HeroManager[] m_Player;
	public bool hasStory = false;
	public int m_DurationStory = 15;
	public GameObject m_Story;
	public Text m_StoryCounter;

	private WaitForSeconds m_StartWait;
	private WaitForSeconds m_EndWait;
	private WaitForSeconds m_HintWait;
	private bool check = false;
	private string str_msg = "";
	private int m_AmountOfDeaths=0;

	// Use this for initialization
	private void Start () {
		m_StartWait = new WaitForSeconds(m_StartDelay);
		m_EndWait = new WaitForSeconds(m_EndDelay);
		m_HintWait = new WaitForSeconds(m_HintDelay);

		SpawnAllPlayers();
		SetCameraTargets();

		StartCoroutine(GameLoop());
	}
	
	private void SpawnAllPlayers(){
		for(int i=0; i < m_Player.Length;i++){
			m_Player[i].m_Instance = Instantiate(m_PlayerPrefab[i], m_Player[i].m_Spawnpoint.position, m_Player[i].m_Spawnpoint.rotation) as GameObject;
			m_Player[i].m_PlayerNumber = m_Player[i].m_Instance.GetComponent<PlayerSettings>().GetPlayerNumber();
			m_Player[i].Setup();
		}
	}

	private void SetCameraTargets(){
		Transform[] targets = new Transform[m_Player.Length];

		for(int i=0; i<targets.Length; i++){
			targets[i] = m_Player[i].m_Instance.transform;
		}

		m_CameraControl.m_Targets = targets;
	}

	private IEnumerator GameLoop(){
		yield return StartCoroutine(LevelStarting());
		yield return StartCoroutine(LevelPlaying());
		yield return StartCoroutine(LevelEnding());
	}

	private IEnumerator LevelStarting(){
		ResetPlayers();
		DisablePlayerControl();

		m_CameraControl.SetStartPositionAndSize(); 

		yield return m_StartWait;
	}

	private IEnumerator LevelPlaying(){
		EnablePlayerControl();
		StartCoroutine(handleHint());

		m_Pause.SetActive(true);
		m_MessageText.text = string.Empty;

		while(check == false){
			yield return null;
			if(m_Player.Length > 1){
				if((m_Player[0].m_Instance.GetComponent<PlayerSettings>().getTargetState() == true) && (m_Player[1].m_Instance.GetComponent<PlayerSettings>().getTargetState() == true)){
					check = true;
					str_msg = "Level finished";
				} 
				if(m_Player[0].m_Instance.GetComponent<PlayerHealth>().getIfDead() == true){
					StartCoroutine(DeathHandling(m_Player[0]));
				}
				if(m_Player[1].m_Instance.GetComponent<PlayerHealth>().getIfDead()==true){
					StartCoroutine(DeathHandling(m_Player[1]));
				}
			} else {
				if((m_Player[0].m_Instance.GetComponent<PlayerSettings>().getTargetState() == true)){
					check = true;
					str_msg = "Level finished";
				}
				if(m_Player[0].m_Instance.GetComponent<PlayerHealth>().getIfDead() == true){
					StartCoroutine(DeathHandling(m_Player[0]));
				}
			}
			if(Input.GetKeyDown("i")){
				StartCoroutine(handleHint());
			}
		}
	}

	private IEnumerator DeathHandling(HeroManager hm){
		m_AmountOfDeaths++;
		m_MessageText.text = "Died: " + m_AmountOfDeaths;
		hm.ResetPlayers();
		yield return m_StartWait;
		m_MessageText.text = string.Empty;
	}

	private IEnumerator LevelEnding(){
		DisablePlayerControl();

		m_MessageText.text = str_msg;

		check = false;

		yield return m_EndWait;

		if(hasStory){
			yield return StartCoroutine(ShowStory());
		}

		switch (m_LvlNumber) {
			case 98:
				SceneManager.LoadScene("Tutorial_Angel");
				break;
			case 99:
				SceneManager.LoadScene("Story_1");
				break;
			case 1: 
				SceneManager.LoadScene("Story_2");
				break;
			case 2:
				SceneManager.LoadScene("Story_3");
				break;
			case 3:
				SceneManager.LoadScene("Story_4");
				break;
			case 4:
				SceneManager.LoadScene("Story_5");
				break;
			case 5:
				SceneManager.LoadScene("MainMenu");
				break;
			default:
				SceneManager.LoadScene("MainMenu");
				break;
		}
	}

	private IEnumerator ShowStory(){
		m_Story.SetActive(true);
		//pause audio

		for(int i=m_DurationStory; i>0; i--){
			m_StoryCounter.text = i.ToString();
			yield return new WaitForSeconds(1f);
		}
	}


	private IEnumerator handleHint(){
		hint.SetActive(true);
		yield return m_HintWait;
		hint.SetActive(false);
	}

	private void ResetPlayers()
    {
        for (int i = 0; i < m_Player.Length; i++)
        {
            m_Player[i].ResetPlayers();
        }
    }


    private void EnablePlayerControl()
    {
        for (int i = 0; i < m_Player.Length; i++)
        {
            m_Player[i].EnableControl();
        }
    }


    private void DisablePlayerControl()
    {
        for (int i = 0; i < m_Player.Length; i++)
        {
            m_Player[i].DisableControl();
        }
    }

	public HeroManager[] getHeroes(){
		return m_Player;
	}

}
