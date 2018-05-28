using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		switch(other.gameObject.name) {
			case "Devil(Clone)":
				other.gameObject.GetComponent<Ability_Jump>().enabled = true;
				other.gameObject.GetComponent<Modificator_Jump>().enabled = true;
				Destroy(transform.parent.gameObject);
				break;
			case "Angel(Clone)":
				break;
			default:
				break;
		}
	}
}
