using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTriggerCanonActivate : MonoBehaviour {
    public GameObject canon;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canon.GetComponent<ScriptTirCanon>().isActive=true;
         
        }
    }
}
