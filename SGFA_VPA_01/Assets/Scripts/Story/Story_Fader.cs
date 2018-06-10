using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story_Fader : MonoBehaviour {

	public Image m_UI;

	public void StartFade(){
		m_UI.SetActive(true);
	}
}
