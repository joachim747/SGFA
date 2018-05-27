using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Observer : MonoBehaviour, ITObserver {


	public int subjectCount;
	public ITSubject[] watchedSubjects;
	Animator animator;
	public bool risen;

    public void onNotify()
    {
		if(risen){
			animator.Play("lower");
		}else{
			animator.Play("rise");
		}
        
    }

    // Use this for initialization
    void Start () {
		foreach (ITSubject subject in watchedSubjects){
			subject.addObserver(this);
		}
		animator = transform.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
