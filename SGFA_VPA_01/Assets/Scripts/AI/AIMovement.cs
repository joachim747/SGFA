using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour {
	public float m_lookRange = 5f;
	public Transform target;
	NavMeshAgent agent;

	void Start(){
		target = GameObject.Find("Angel(Clone)").transform;
		agent = GetComponent<NavMeshAgent>();
	}

	void Update () {
		float distance = Vector3.Distance(target.position, transform.position);

		if(distance <= m_lookRange){
			agent.SetDestination(target.position);
		}
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, m_lookRange);
	}
}
