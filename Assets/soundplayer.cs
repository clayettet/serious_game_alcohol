using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundplayer : MonoBehaviour {

    public AudioClip BackgroundMusic;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(AudioClip clip)
    {
        GameObject Go = new GameObject();
        AudioSource audioSource = Go.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();
        GameObject.Destroy(Go, audioSource.clip.length + 0.1f);
    }
}
