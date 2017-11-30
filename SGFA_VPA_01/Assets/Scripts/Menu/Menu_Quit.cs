using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Quit : MonoBehaviour {

	public void CloseApplication(){
		Debug.Log("Game has been quitted");
		Application.Quit();
	}
	
}
