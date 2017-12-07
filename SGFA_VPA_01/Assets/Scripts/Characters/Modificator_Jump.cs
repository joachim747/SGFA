using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modificator_Jump : MonoBehaviour {

	public float m_FallMultiplier=2.5f;
	public float m_LowJumpMultiplier=2f;

	Rigidbody player;

	void Awake(){
		player = GetComponent<Rigidbody>();
	}

	void Update(){
		if(player.velocity.y<0){
			player.velocity += Vector3.up * Physics.gravity.y * (m_FallMultiplier - 1) * Time.deltaTime;
		}
	}
}
