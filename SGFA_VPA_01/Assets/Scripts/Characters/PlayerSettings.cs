using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour {

	public bool inZone = false;

	public void setTargetState(bool newState){
		inZone = newState;
	}

	public bool getTargetState(){
		return inZone;
	}

}
