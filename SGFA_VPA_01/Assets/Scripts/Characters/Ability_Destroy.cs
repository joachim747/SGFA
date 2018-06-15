using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Destroy : MonoBehaviour {

    private Animator anim;
    private List<Collider> collider_list = new List<Collider>();

    void OnTriggerEnter(Collider col)
    {
        collider_list.Add(col);
    }

    void OnTriggerExit(Collider col)
    {
        collider_list.Remove(col);
    }

    private void Start()
    {
        anim = transform.parent.GetComponentInChildren<Animator>();
    }

	void Update(){
		if(Input.GetButtonDown("Attack") && collider_list.Count > 0){

            anim.SetTrigger("Attack");
            StartCoroutine(Attack());

        }
	}

    IEnumerator Attack()
    {
       
        yield return new WaitForSeconds(0.3f);
        for (int i = 1; i < collider_list.Count; i++)
        {
            var go = collider_list[i];
            if (go.gameObject.tag == "Box")
            {
                collider_list.Remove(go);
                go.GetComponent<Destroyable>().destroyObject();
            }
            if (go.gameObject.tag == "Enemy")
            {
                go.GetComponent<AIHealth>().TakeDamage(15f);

                if (go.GetComponent<AIHealth>().GetHealth() <= 0f)
                {
                    collider_list.Remove(go);
                }
            }
        }
    }
}
