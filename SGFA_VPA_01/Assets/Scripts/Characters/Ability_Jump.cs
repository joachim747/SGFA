using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Jump : MonoBehaviour {

	[Range(1,10)] public float m_JumpVelocity = 4;

	void Update(){

		if(Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody>().velocity = Vector3.up * m_JumpVelocity;
		}
		
	}
}
