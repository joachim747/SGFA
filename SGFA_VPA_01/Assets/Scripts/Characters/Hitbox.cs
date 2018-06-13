using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {

    public List<Collider> collider = new List<Collider>();

    void OnTriggerEnter(Collider col)
    {
        collider.Add(col);
        //Debug.Log(col.name + " entered");
    }

    void OnTriggerExit(Collider col)
    {
        collider.Remove(col);
    }

    public List<Collider> getItemsInHitbox()
    {
        return collider;
    }

}
