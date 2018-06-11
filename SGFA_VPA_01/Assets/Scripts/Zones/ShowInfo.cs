using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfo : MonoBehaviour {

	public string m_Text;
	public GameObject m_InfoBox;
	public Text message; 

	private WaitForSeconds m_InfoWait = new WaitForSeconds(3f);

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			StartCoroutine(ShowMessage(m_Text));
		}
	}

	private IEnumerator ShowMessage(string text){
		message.text = text;
		m_InfoBox.SetActive(true);
		yield return m_InfoWait;
		m_InfoBox.SetActive(false);
	}
}
