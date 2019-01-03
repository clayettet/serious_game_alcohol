using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute : MonoBehaviour {

    public AudioSource source;

    public AudioClip BackgroundMusic;
    public AudioClip PiedDuFou;

	// Use this for initialization
	void Start () {
        source.clip = BackgroundMusic;
        source.mute = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.O))
        {
            source.mute = !source.mute;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if(source.clip == BackgroundMusic)
            {
                source.clip = PiedDuFou;
                source.Play();
            } else
            {
                source.clip = BackgroundMusic;
                source.Play();
            }
        }
    }
}
