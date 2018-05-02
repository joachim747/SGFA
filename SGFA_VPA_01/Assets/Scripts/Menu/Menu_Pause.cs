using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Pause : MonoBehaviour {

	public static bool m_GameIsPaused = false;
	public GameObject m_PauseMenuUI;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){	
			if(m_GameIsPaused){
				Resume();
			} else {
				Pause();
			}
		}
	}

	public void Resume(){
		m_PauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		m_GameIsPaused = false;
	}

	private void Pause(){
		m_PauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		m_GameIsPaused = true;
	}

	public void ReturnToMenu(){
		SceneManager.LoadScene("MainMenu");
	}

	public void QutiGame(){
		Application.Quit();
	}

}
