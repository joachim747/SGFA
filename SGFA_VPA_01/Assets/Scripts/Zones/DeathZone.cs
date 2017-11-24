using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			col.gameObject.GetComponent<PlayerHealth>().DecreaseOverTime(25f);
		}
	}
}
