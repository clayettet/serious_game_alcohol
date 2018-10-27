// https://answers.unity.com/questions/1370298/changing-post-processing-profile-via-scripting.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class AlcoholEffect : MonoBehaviour {

    public PostProcessingProfile drunkProfile;
    public PostProcessingProfile normalProfile;

    private bool isDrunk = false;

    float level;

    // Use this for initialization
    void Start () {
        //level = GameObject.Find("AlcoholLevel").GetComponent<AlcoholLevel>().level;
    }
	
	// Update is called once per frame
	void Update () {
        /* DO NOT DELETE - FINAL FUNCTION WILL BE LIKE THIS
         if (level < 0.5f)
          {
                GetComponent<PostProcessingBehaviour>().profile = normalProfile;
                isDrunk = false;
                Debug.Log("is ndrunk");
          }
         else
          {
            GetComponent<PostProcessingBehaviour>().profile = drunkProfile;
            isDrunk = true;
            Debug.Log("is drunk");
          }*/

        // SWITCH TO TEST EFFECT - WILL BE DELETED
        if (Input.GetKeyDown(KeyCode.P))
            if (isDrunk)
            {
                GetComponent<PostProcessingBehaviour>().profile = normalProfile;
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
