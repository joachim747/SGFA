using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		//ramming -- inverted could be used for deathzones
		if(col.gameObject.name == "Devil(Clone)"){
			Destroy(this.gameObject);
		}
	}
}
