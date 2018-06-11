using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseHealthDirectly : MonoBehaviour {

	void Start(){
		StartCoroutine(takeHealth());
	}

	private IEnumerator takeHealth(){
		yield return new WaitForSeconds(2);
		gameObject.GetComponent<PlayerHealth>().TakeDamage(75f);
	}

}
