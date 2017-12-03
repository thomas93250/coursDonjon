using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTriggerElevator : MonoBehaviour {
    public GameObject oldParent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
     
        
            other.gameObject.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
     
            other.gameObject.transform.parent = oldParent.transform;
        }
    }
    // Update is called once per frame
    void Update () {
        

    }
}
