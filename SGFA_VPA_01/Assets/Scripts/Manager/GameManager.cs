using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int m_NumLevelsToComplete = 1;
	public float m_StartDelay = 3f;
	public float m_EndDelay = 3f;
	public CameraControl m_CameraControl;
	public Text m_MessageText;
	public GameObject m_PlayerPrefab;
	public HeroManager[] m_Player;

	private int m_LvlNumber;
	private bool m_goalAchieved = false;
	private WaitForSeconds m_StartWait;
	private WaitForSeconds m_EndWait;
	private HeroManager mvp;
	private bool check = false;

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
			m_Player[i].m_Instance = Instantiate(m_PlayerPrefab, m_Player[i].m_Spawnpoint.position, m_Player[i].m_Spawnpoint.rotation) as GameObject;
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

		//yield return m_StartWait;
		m_MessageText.text = "Reach the other side";
		
		yield return m_StartWait;
	}

	private IEnumerator LevelPlaying(){
		EnablePlayerControl();

		m_MessageText.text = string.Empty;

		while(check == false){
			yield return null;
			if((m_Player[0].m_Instance.GetComponent<PlayerSettings>().getTargetState() == true) && (m_Player[1].m_Instance.GetComponent<PlayerSettings>().getTargetState() == true)){
				check = true;
			}
		}
	}

	private IEnumerator LevelEnding(){
		DisablePlayerControl();

		mvp = null;

		m_MessageText.text = "Level finished";

		yield return m_EndWait;
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
