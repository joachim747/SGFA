using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour {

	public float m_Seconds;
	public string m_Scene;

	// Use this for initialization
	void Start () {
		StartCoroutine(WaitandLoad(m_Seconds, m_Scene));
	}

	void Update(){
		if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")){
			SceneManager.LoadScene(m_Scene);
		}
	}

	private IEnumerator WaitandLoad(float seconds, string scene){
		yield return new WaitForSeconds(seconds);
		SceneManager.LoadScene(scene);
	}
}
