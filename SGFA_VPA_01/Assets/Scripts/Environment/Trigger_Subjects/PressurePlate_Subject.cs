using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate_Subject : MonoBehaviour, ITSubject {
    public List<ITObserver> observers
    {
        get
        {
            return observers;
        }

		set{
		
		}
    }

	void Start () {
		observers = new List<ITObserver>();
	}
    public void notify()
    {
        foreach (ITObserver observer in observers)
		{
			observer.onNotify();
		}
    }

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			notify();
		}
	}

	public void addObserver(ITObserver observer){
		observers.Add(observer);
	}

	public void removeObserver(ITObserver observer){
		observers.Remove(observer);
	}

	
}
