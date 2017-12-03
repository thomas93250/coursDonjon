using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTriggerDoor : MonoBehaviour {
    public GameObject door;

     // Use this for initialization
     void Start () {

    }

    private void OnTriggerEnter(Collider other)
     {
        if(other.gameObject.tag=="Player")
        {
            door.GetComponent<Animator>().SetBool("isOpen", true);
            //transform.GetChild(2).GetComponent
            //for(int i=0;i<transform.childCount;i++)
        }
    }




}
