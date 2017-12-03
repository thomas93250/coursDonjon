using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpike : MonoBehaviour {
    public float delay;
    public Vector3 StartPosition;
    public Vector3 EndPosition;
    public float Timer;
    public bool isActivate;
    public AudioSource audioSource;
    public AudioClip spikeSound;
    public float speed = 2f;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        isActivate = true;
        StartPosition = this.transform.localPosition;
        EndPosition = this.transform.localPosition + new Vector3(0, -4,0);
    }
	//loic.janin@
	// Update is called once per frame
	void Update () {
        if(isActivate)
            Timer += speed* Time.deltaTime;
        else
            Timer -= speed*Time.deltaTime;

        if (Timer > 1f + delay)
        {
            isActivate = false;
            audioSource.PlayOneShot(spikeSound);
        }
        else if (Timer < -2f)
        {

            isActivate = true;
        }

        transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, Timer);
    }
}
