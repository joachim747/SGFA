using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour {
	private List<Transform> targets = new List<Transform>();
	private Transform m_Target, m_Enemy;
	NavMeshAgent agent;

	void Start(){
		agent = gameObject.transform.parent.gameObject.GetComponent<NavMeshAgent>();
		m_Enemy = gameObject.transform.parent.gameObject.transform;
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			targets.Add(col.gameObject.transform);
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Player"){
			targets.Remove(col.gameObject.transform);
		}
	}

	void OnTriggerStay(){
		if(targets.Count > 0){
			m_Target = targets[0];
			agent.SetDestination(m_Target.position);

			float distance = Vector3.Distance(m_Target.position, m_Enemy.position);

			if(distance <= agent.stoppingDistance){
				FaceTarget();
			}
		}
	}

	private void FaceTarget(){
		Vector3 direction = (m_Target.position - m_Enemy.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		m_Enemy.rotation = Quaternion.Slerp(m_Enemy.rotation, lookRotation, Time.deltaTime * 5f);
	}
}
