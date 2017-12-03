using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptKey : MonoBehaviour {
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(door);

        }
    }
}
