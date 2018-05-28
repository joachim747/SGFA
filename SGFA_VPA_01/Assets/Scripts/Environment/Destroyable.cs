using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour {

	public GameObject destroyedVersion;

	public void destroyObject(){
		Instantiate(destroyedVersion, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
