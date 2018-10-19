// https://answers.unity.com/questions/1370298/changing-post-processing-profile-via-scripting.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class AlcoholEffect : MonoBehaviour {

    public PostProcessingProfile alcoholProfile;

    PostProcessingProfile prof;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P)){
             prof = GetComponent<PostProcessingBehaviour>().profile = alcoholProfile;
        }
	}
}
