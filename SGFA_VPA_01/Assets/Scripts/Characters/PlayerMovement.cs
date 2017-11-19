using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

	public int m_PlayerNumber = 1; //used for controls (which character)
	public float m_Speed = 12f;
	public float m_TurnSpeed = 180f;
	//public AudioSource m_MovementAudio;
	public float m_PitchRange = 0.2f; //used for audio pitch

	private string m_MovementAxisName; //based on the player number it needs to be changed
	private string m_TurnAxisName;
	private Rigidbody m_Rigidbody; //reference to the players rigidbody -- used to move around
	private float m_MovementInputValue;
	private float m_TurnInputValue;
	private float m_OriginalPitch;


	public int getPlayerNumber(){
		return m_PlayerNumber;
	}

	private void Awake(){
		m_Rigidbody = GetComponent<Rigidbody>();
	}

	private void OnEnable(){
		m_Rigidbody.isKinematic = false; //kinematic: no forces will be applied - after level
		m_MovementInputValue = 0f;
		m_TurnInputValue = 0f;
	}

	private void OnDisable(){
		m_Rigidbody.isKinematic = true;
	}

	private void Start () {
		m_MovementAxisName = "Vertical" + m_PlayerNumber;
		m_TurnAxisName = "Horizontal" + m_PlayerNumber;

		//m_OriginalPitch = m_MovementAudio.pitch;
	}
	
	private void Update () {
		//running every frame
		m_MovementInputValue = Input.GetAxis(m_MovementAxisName);
		m_TurnInputValue = Input.GetAxis(m_TurnAxisName);
		
		//WalkAudio();
	}

	/*private void WalkAudio(){
		//play sound whether player has moved or not

		if(Mathf.Abs(m_MovementInputValue) < 0.1f && Mathf.Abs (m_TurnInputValue) < 0.1f){
			//pitching and play music
		}else{
			//pitching and play music
		}
	}*/

	private void FixedUpdate(){
		//runs every physics step
		Move();
		Turn();
	}

	private void Move(){
		Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime;

		m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
	}

	private void Turn(){
		float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;

		Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

		m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
	}

	void OnCollisionEnter(Collision col){
		//ramming -- inverted could be used for deathzones
		if(col.gameObject.name == "testcube"){
			Destroy(col.gameObject);
		}
	}

}
