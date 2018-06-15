using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Destroy : MonoBehaviour {

    private Animator anim;
    private List<Collider> collider = new List<Collider>();

    void OnTriggerEnter(Collider col)
    {
        collider.Add(col);
    }

    void OnTriggerExit(Collider col)
    {
        collider.Remove(col);
    }

    private void Start()
    {
        anim = transform.parent.GetComponentInChildren<Animator>();
    }

	void Update(){
		if(Input.GetButtonDown("Attack") && collider.Count > 0){

            anim.SetTrigger("Attack");
            StartCoroutine(Attack());

        }
	}

    IEnumerator Attack()
    {
       
        yield return new WaitForSeconds(0.3f);
        for (int i = 1; i < collider.Count; i++)
        {
            var go = collider[i];
            if (go.gameObject.tag == "Box")
            {
                go.GetComponent<Destroyable>().destroyObject();
                collider.Remove(go);
            }
            if (go.gameObject.tag == "Enemy")
            {
                go.GetComponent<AIHealth>().TakeDamage(15f);

                if (go.GetComponent<AIHealth>().GetHealth() <= 0f)
                {
                    collider.Remove(go);
                }
            }
        }
    }
}
