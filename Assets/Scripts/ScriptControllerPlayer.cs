using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptControllerPlayer : MonoBehaviour {
    public int nbPieces=0;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip deathSound;
    public GameObject respawn;
    void Update()
    {
        /*RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10.0f))
            Debug.Log("distance: " + hit.transform.localPosition);*/

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                audioSource.PlayOneShot(jumpSound);
                moveDirection.y = jumpSpeed;
            }

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "checkpoint")
        {
            respawn = other.gameObject;
        }
        if (other.gameObject.tag == "Death")
        {
            audioSource.PlayOneShot(deathSound);
            transform.position = new Vector3(respawn.transform.position.x, respawn.transform.position.y, respawn.transform.position.z);
        }
    }
}
