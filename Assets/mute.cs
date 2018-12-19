using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute : MonoBehaviour {

    public AudioSource source;

	// Use this for initialization
	void Start () {
        source.mute = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.O))
        {
            source.mute = !source.mute;
        }
    }
}
