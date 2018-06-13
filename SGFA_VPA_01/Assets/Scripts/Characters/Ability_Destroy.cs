using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Destroy : MonoBehaviour {

    public GameObject hit;
    private Animator anim;
    private Hitbox hitbox;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        hitbox = hit.GetComponent<Hitbox>();
    }

	void Update(){
		if(Input.GetButtonDown("Attack") && hitbox.getItemsInHitbox().Count > 0){

            anim.SetTrigger("Attack");
            StartCoroutine(Attack());

        }
	}

    IEnumerator Attack()
    {
       
        yield return new WaitForSeconds(0.3f);
        foreach (Collider go in hitbox.collider)
        {
            if (go.gameObject.tag == "Box")
            {
                go.GetComponent<Destroyable>().destroyObject();
                hitbox.collider.Remove(go);
            }
            if (go.gameObject.tag == "Enemy")
            {
                go.GetComponent<AIHealth>().TakeDamage(15f);

                if (go.GetComponent<AIHealth>().GetHealth() <= 0f)
                {
                    hitbox.collider.Remove(go);
                }
            }
        }
    }
}
