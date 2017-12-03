using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTirCanon : MonoBehaviour {
    public GameObject bullet;
    public Transform bulletSpawn1;
    public Transform bulletSpawn2;
    public Transform bulletSpawn3;
    public float cadence;
    public float speed;
    public float bulletLifetime;
    public float comptDoubleBullet=0;
    public float compteurDoubleShot;
    public bool isActive=false;
    public AudioSource audioSource;
    public AudioClip canonSound;
    private float t=0f;
    // Use this for initialization
    void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if(isActive==true) { 
         t = t+Time.deltaTime;
            if (t > cadence)
            {

                var alea = Random.Range(0, 3);
                if (alea == 0)
                    bullet = (GameObject)Instantiate(bullet, bulletSpawn1.position, bulletSpawn1.rotation);
                else if (alea == 1)
                    bullet = (GameObject)Instantiate(bullet, bulletSpawn2.position, bulletSpawn2.rotation);
                else
                    bullet = (GameObject)Instantiate(bullet, bulletSpawn3.position, bulletSpawn2.rotation);

                audioSource.PlayOneShot(canonSound);
                bullet.GetComponent<Rigidbody>().velocity = gameObject.transform.right * speed;
                Destroy(bullet, bulletLifetime);
                t = 0;


                if (comptDoubleBullet == compteurDoubleShot)
                {
                    var alea2 = Random.Range(0, 3);
                    while (alea == alea2)
                        alea2 = Random.Range(0, 3);

                    if (alea2 == 0)
                        bullet = (GameObject)Instantiate(bullet, bulletSpawn1.position, bulletSpawn1.rotation);
                    else if (alea2 == 1)
                        bullet = (GameObject)Instantiate(bullet, bulletSpawn2.position, bulletSpawn2.rotation);
                    else
                        bullet = (GameObject)Instantiate(bullet, bulletSpawn3.position, bulletSpawn2.rotation);

                    audioSource.PlayOneShot(canonSound);
                    bullet.GetComponent<Rigidbody>().velocity = gameObject.transform.right * speed;
                    Destroy(bullet, bulletLifetime);
                    comptDoubleBullet = 0;
                }

                comptDoubleBullet += 1;
            }
            
        }
    }
}
