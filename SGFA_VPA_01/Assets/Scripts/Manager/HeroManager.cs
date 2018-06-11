using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class HeroManager 
{
	public Color m_PlayerColor;
	public Transform m_Spawnpoint;
	[HideInInspector] public int m_PlayerNumber;
	[HideInInspector] public string m_ColoredPlayerText;
	[HideInInspector] public GameObject m_Instance;
	[HideInInspector] public int m_Mvp;

	private PlayerMovement m_Movement;
	private GameObject m_CanvasGameObject;

	public void Setup(){
		m_Movement = m_Instance.GetComponent<PlayerMovement>();
		m_CanvasGameObject = m_Instance.GetComponentInChildren<Canvas>().gameObject;

		m_Movement.m_PlayerNumber = m_PlayerNumber;
		
		m_ColoredPlayerText = "<color=#" + ColorUtility.ToHtmlStringRGB(m_PlayerColor) + "<PLAYER " + m_PlayerNumber + "</color>";

		MeshRenderer[] renderers = m_Instance.GetComponentsInChildren<MeshRenderer>();

		for(int i =0;i<renderers.Length; i++){
			renderers[i].material.color = m_PlayerColor;
		}
	}

	public void DisableControl(){
		m_Movement.enabled=false;
		
		m_CanvasGameObject.SetActive(false);
	}

	public void EnableControl(){
		m_Movement.enabled=true;

		m_CanvasGameObject.SetActive(true);
	}

	public void ResetPlayers(){
		m_Instance.transform.position = m_Spawnpoint.position;
		m_Instance.transform.rotation = m_Spawnpoint.rotation;

		m_Instance.SetActive(false);
		m_Instance.SetActive(true);
	}

}
