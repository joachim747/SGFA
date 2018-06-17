using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Jump : MonoBehaviour {

	[Range(1,10)] public float m_JumpVelocity = 4;
    public ParticleSystem jumpParticles;
    private Animator anim;
    private float distanceToGround = 0.2f;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update(){
		if(Input.GetButtonDown("Jump") && isGrounded()){
            anim.SetTrigger("Jump");
            StartCoroutine(Jump());
		}
	}

    private bool isGrounded(){
        return Physics.Raycast(transform.position, -Vector3.up, distanceToGround);
    }

    IEnumerator Jump()
    {  
        yield return new WaitForSeconds(0.5f);
        Instantiate(jumpParticles, transform.position, Quaternion.Euler(90, 0, 0));
        GetComponent<Rigidbody>().velocity = Vector3.up * m_JumpVelocity;
    }
}
