using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int m_NumLevelsToComplete = 1;
	public float m_StartDelay = 3f;
	public float m_EndDelay = 3f;
	public CameraControl m_CameraControl;
	//public Text m_MessageText;
	public GameObject[] m_PlayerPrefab;
	public HeroManager[] m_Player;

	private int m_LvlNumber;
	private WaitForSeconds m_StartWait;
	private WaitForSeconds m_EndWait;

	// Use this for initialization
	private void Start () {
		m_StartWait = new WaitForSeconds(m_StartDelay);
		m_EndWait = new WaitForSeconds(m_EndDelay);

		SpawnAllPlayers();
		SetCameraTargets();

		//StartCoroutine(GameLoop());
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

}
