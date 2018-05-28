using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLight : MonoBehaviour {

	Light fire;
	float intensity = 0f, x = 1f;
	public float minIntens = 3f, maxIntens = 5f, speed = 1;

	// Use this for initialization
	void Start () {
		fire = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		intensity = Mathf.Sin(x * maxIntens * Mathf.PI) + minIntens + (maxIntens/2) + Random.Range(0 , 0.6f) ;
		fire.intensity = intensity;
		x = x + speed/50;
	}
}
