using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone_Stay : MonoBehaviour {

	void OnTriggerStay(Collider col){
		if(col.gameObject.tag == "Player"){
			col.gameObject.GetComponent<PlayerHealth>().TakeDamage(.5f);
		}
	}
}
