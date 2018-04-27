using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public int m_LvlNumber;
	public float m_StartDelay = 3f;
	public float m_EndDelay = 3f;
	public CameraControl m_CameraControl;
	public Text m_MessageText;
	public GameObject[] m_PlayerPrefab;
	public HeroManager[] m_Player;

	private WaitForSeconds m_StartWait;
	private WaitForSeconds m_EndWait;
	private bool check = false;
	private string str_msg = "";
	private int m_AmountOfDeaths=0;

	// Use this for initialization
	private void Start () {
		m_StartWait = new WaitForSeconds(m_StartDelay);
		m_EndWait = new WaitForSeconds(m_EndDelay);

		SpawnAllPlayers();
		SetCameraTargets();

		StartCoroutine(GameLoop());
	}
	
	private void SpawnAllPlayers(){
		for(int i=0; i < m_Player.Length;i++){
			m_Player[i].m_Instance = Instantiate(m_PlayerPrefab[i], m_Player[i].m_Spawnpoint.position, m_Player[i].m_Spawnpoint.rotation) as GameObject;
			m_Player[i].m_PlayerNumber = i+1;
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
		m_MessageText.text = "Reach the zone";
		
		yield return m_StartWait;
	}

	private IEnumerator LevelPlaying(){
		EnablePlayerControl();

		m_MessageText.text = string.Empty;

		while(check == false){
			yield return null;
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
			if (Input.GetKeyDown(KeyCode.Escape)){
            	Debug.Log("Back to MainMenu");
				SceneManager.LoadScene("MainMenu");
				break;
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

		switch (m_LvlNumber) {
			case 1: 
				SceneManager.LoadScene("Story_2");
				break;
			case 2:
				SceneManager.LoadScene("Story_3");
				break;
			case 3:
				SceneManager.LoadScene("MainMenu");
				break;
			case 4:
				SceneManager.LoadScene("MainMenu");
				break;
			default:
				SceneManager.LoadScene("MainMenu");
				break;
		}
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

}
