using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public float m_StartingHealth = 100f;
	public Slider m_Slider;
	public Image m_FillImage;
	public Color m_FullHealthColor = Color.green;
	public Color m_ZeroHealthColor = Color.red;
	//public GameObject m_ExplosionPrefab;

	private float m_CurrentHealth;
	private bool m_Dead;
	private bool healable = true;

	public void IncreaseHealth(float additionalHealth){
		if(healable){
			StartCoroutine(addHealth(additionalHealth));
		}
	}

	private IEnumerator addHealth(float amount){
		healable = false;
		while (amount > 0){ 
			if (m_CurrentHealth < 100){ 
				m_CurrentHealth += 1; 
				SetHealthUI();
				amount -= 1;
				yield return 5;
			} else { 
				yield return null;
			}
		}
		healable = true;
	}

	private void OnEnable(){
		m_CurrentHealth = m_StartingHealth;
		m_Dead = false;

		SetHealthUI();
	}

	public void TakeDamage(float amount){
		m_CurrentHealth -= amount;

		SetHealthUI();

		if(m_CurrentHealth <= 0f && !m_Dead){
			OnDeath();
		}
	}

	private void SetHealthUI(){
		m_Slider.value = m_CurrentHealth;

		m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
	}

	private void OnDeath(){
		//effects & sounds? menues? 
		m_Dead = true;

		gameObject.SetActive(false);
	}

	public bool getIfDead(){
		return m_Dead;
	}
}
