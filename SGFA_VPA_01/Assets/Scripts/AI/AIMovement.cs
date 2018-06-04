using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour {
	private List<Transform> targets = new List<Transform>();
	private Transform m_Target, m_Enemy;
	private List<GameObject> players = new List<GameObject>();
	private GameObject m_Player;
	NavMeshAgent agent;

	void Start(){
		agent = gameObject.transform.parent.gameObject.GetComponent<NavMeshAgent>();
		m_Enemy = gameObject.transform.parent.gameObject.transform;
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			targets.Add(col.gameObject.transform);
			players.Add(col.gameObject);
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Player"){
			targets.Remove(col.gameObject.transform);
			players.Remove(col.gameObject);
		}
	}

	void OnTriggerStay(){
		if(targets.Count > 0){
			m_Target = targets[0];
			m_Player = players[0];
			agent.SetDestination(m_Target.position);

			float distance = Vector3.Distance(m_Target.position, m_Enemy.position);

			if(distance <= agent.stoppingDistance){
				FaceTarget();
			}

			if(m_Player.GetComponent<PlayerHealth>().getIfDead()){
				targets.Remove(m_Target);
				players.Remove(m_Player);
				m_Player = null;
				m_Target = null;
			}
		}
	}

	private void FaceTarget(){
		Vector3 direction = (m_Target.position - m_Enemy.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		m_Enemy.rotation = Quaternion.Slerp(m_Enemy.rotation, lookRotation, Time.deltaTime * 5f);
	}
}
