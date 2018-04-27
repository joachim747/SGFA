using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour {
	
	public GameObject image;
	private int playerInZone = 0;

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			playerInZone++;
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Player"){
			playerInZone--;
		}
	}

	void Update () {
		if(playerInZone>0){
			image.SetActive(true);
		} else {
			image.SetActive(false);
		}
	}
}
