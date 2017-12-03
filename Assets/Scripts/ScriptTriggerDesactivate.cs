using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTriggerDesactivate : MonoBehaviour {

    public GameObject canon;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canon.GetComponent<ScriptTirCanon>().isActive = false;

        }
    }
}
