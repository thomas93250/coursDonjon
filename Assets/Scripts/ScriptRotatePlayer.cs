using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRotatePlayer : MonoBehaviour {

    public GameObject trigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "triggerRotate")
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "triggerRotate")
        {
            Debug.Log("EXIT");
            transform.Rotate(new Vector3(0, -90, 0));
        }
    }
}
