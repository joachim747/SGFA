using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stones : MonoBehaviour {

	Animator animator;
	public int player;
	public GameObject infobox;
	public Text message;
	//public int number;
	//public GameObject ActivationHandler;

	private WaitForSeconds m_InfoWait = new WaitForSeconds(4f);

	void Start () {
		animator = transform.parent.GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other) {
		if(player == other.GetComponent<PlayerMovement>().m_PlayerNumber){
			animator.Play("Move_Up");
			StartCoroutine(handleMessage());
			//ActivationHandler.GetComponent<ActivationHandler>().setActivation(number);
		}
	}

	private IEnumerator handleMessage(){
		message.text = "Trigger sucessfully activated.";
		infobox.SetActive(true);
		yield return m_InfoWait;
		infobox.SetActive(false);
	}
}
