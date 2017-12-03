using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCameraPlayer : MonoBehaviour {

    public GameObject camera;
    public GameObject trigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "triggerCamera")
        {
            camera.transform.rotation =  Quaternion.Euler(90, 0, 0);
            camera.transform.localPosition=(new Vector3(0, 15, 1));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "triggerCamera")
        {
            camera.transform.rotation = Quaternion.Euler(30, 0, 0);
            camera.transform.localPosition = (new Vector3(0, 5, -4));
        }
    }
}
