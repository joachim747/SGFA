using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour {

	public void CloseApplication(){
		Debug.Log("Game has been quitted");
	}

	public void OpenWebsite(string url){
		Application.OpenURL(url);
	}
}
