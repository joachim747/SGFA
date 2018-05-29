using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIHealth : MonoBehaviour {

	public float m_StartingHealth = 50f;
	public Slider m_Slider;
	public Image m_FillImage;
	public Color m_FullHealthColor = Color.green;
	public Color m_ZeroHealthColor = Color.red;
	//public GameObject m_ExplosionPrefab;

	private float m_CurrentHealth;

	private void OnEnable(){
		m_CurrentHealth = m_StartingHealth;

		SetHealthUI();
	}

	public void GetHealth(){
		return m_CurrentHealth;
	}

	public void TakeDamage(float amount){
		m_CurrentHealth -= amount;

		SetHealthUI();

		if(m_CurrentHealth <= 0f){
			OnDeath();
		}
	}

	private void SetHealthUI(){
		m_Slider.value = m_CurrentHealth;

		m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
	}

	private void OnDeath(){
		//effects & sounds? menues? 
		gameObject.SetActive(false);
	}
}
