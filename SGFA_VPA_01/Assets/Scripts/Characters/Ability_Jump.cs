using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Jump : MonoBehaviour {

	[Range(1,10)] public float m_JumpVelocity = 4;
    public ParticleSystem jumpParticles;
    private Animator anim;
    

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update(){

		if(Input.GetButtonDown("Jump")){
            anim.SetTrigger("Jump");
            StartCoroutine(Jump());
            
		}
		
	}

    IEnumerator Jump()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(jumpParticles, transform.position, Quaternion.identity);
        GetComponent<Rigidbody>().velocity = Vector3.up * m_JumpVelocity;
    }
}
