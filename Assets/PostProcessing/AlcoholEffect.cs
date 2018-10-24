// https://answers.unity.com/questions/1370298/changing-post-processing-profile-via-scripting.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class AlcoholEffect : MonoBehaviour {

    public PostProcessingProfile drunkProfile;
    public PostProcessingProfile normalProfile;

    private bool isDrunk = false;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
            if (isDrunk)
            {
                PostProcessingProfile ppp = GetComponent<PostProcessingBehaviour>().profile = normalProfile;
                isDrunk = false;
                Debug.Log("is ndrunk");
            } else
            {
                GetComponent<PostProcessingBehaviour>().profile = drunkProfile;
                isDrunk = true;
                Debug.Log("is drunk");
            }
    }
}
