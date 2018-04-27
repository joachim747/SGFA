using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ActivationHandler : MonoBehaviour {

	public int[] requiredActivation = new int[2];
	public int[] activationList = new int[2];
	public bool check = true;
	public Text m_MessageText;
	public GameObject[] stones = new GameObject[2];

	private Animator animator;
	private int counter = 0;
	private WaitForSeconds m_Wait = new WaitForSeconds(3f);

	public void setActivation(int activated){
		activationList[counter] = activated;
		Debug.Log(counter);
		if(counter == 1){
			if(checkActivation() != true){
				StartCoroutine(handleWrongActivation());
			}
		}
		counter++;
	}

	private IEnumerator handleWrongActivation(){
		activationList = new int[2];
		counter = 0;
		m_MessageText.text = "Wrong Activation-Order";
		yield return m_Wait;
		m_MessageText.text = "";
		resetStones();
		Debug.Log(counter);
	}

	private void resetStones() {
		for(int i=0;i<stones.Length;i++){
			animator = stones[i].GetComponent<Animator>();
			animator.SetFloat("Direction", -1.0f);
			animator.Play("Move_Up");
		}
	}

	private bool checkActivation() {
		for(int i=0; i<requiredActivation.Length; i++){
			if (requiredActivation[i] == activationList[i]) {
				check = true;
			} else {
				check = false;
			}
		}
		return check;
	}
}
