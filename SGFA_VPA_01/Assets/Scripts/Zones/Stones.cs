using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stones : MonoBehaviour {

	Animator animator;

	void Start () {
		animator = transform.parent.GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other) {
		animator.Play("Move_Up");
	}
}
