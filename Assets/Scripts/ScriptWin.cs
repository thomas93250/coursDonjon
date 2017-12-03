using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScriptWin : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip winSound;
    public Text winText;
    public GameObject player;
    public AudioSource audioSource2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<ScriptControllerPlayer>().enabled = false;
            audioSource2.enabled = false;
            audioSource.PlayOneShot(winSound);
            winText.text= "YOU WIN";
        }
    }
}
