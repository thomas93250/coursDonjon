using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptPiece : MonoBehaviour {
    public GameObject door;
    public float speedRotator;
    public Text textNbPieces;
    public AudioSource audioSource;
    public AudioClip coinSound;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, speedRotator) * Time.deltaTime);
        /*RaycastHit hit;*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<ScriptControllerPlayer>().nbPieces+=1;
            int nbPlayerPieces = other.gameObject.GetComponent<ScriptControllerPlayer>().nbPieces;
            textNbPieces.text = "Pieces : " + nbPlayerPieces + "";
            audioSource.PlayOneShot(coinSound);
            if (other.gameObject.GetComponent<ScriptControllerPlayer>().nbPieces == 9)
                Destroy(door);
            Destroy(gameObject);
            
        }
    }
}
