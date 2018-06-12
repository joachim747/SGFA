using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	private List<GameObject> m_PlayersOutOfZone = new List<GameObject>();

	void Update(){
		if(m_PlayersOutOfZone.Count > 0){
			foreach (GameObject go in m_PlayersOutOfZone) {
				go.GetComponent<PlayerHealth>().TakeDamage(.5f);
			}
		}
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			m_PlayersOutOfZone.Remove(col.gameObject);
			if(col.gameObject.transform.Find("PlayerType").tag == "Angel"){
				col.gameObject.transform.Find("RangeOfHealing").GetComponent<Ability_Heal>().enabled = true;
			}
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Player"){
			m_PlayersOutOfZone.Add(col.gameObject);
			if(col.gameObject.transform.Find("PlayerType").tag == "Angel"){
				col.gameObject.transform.Find("RangeOfHealing").GetComponent<Ability_Heal>().enabled = false;
			}
		}
	}
}
