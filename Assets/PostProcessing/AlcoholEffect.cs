using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class AlcoholEffect : MonoBehaviour {

    public PostProcessingProfile drunkProfile;
    public PostProcessingProfile normalProfile;

    private bool isDrunk = false; //TO DELETE IN FINAL VERSION

    public AlcoholLevel AlcoholLevelManager;
    

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        /// DO NOT DELETE - FINAL FUNCTION WILL BE LIKE THIS
        if (AlcoholLevel.level < 0.5f)
          {
                GetComponent<PostProcessingBehaviour>().profile = normalProfile;
          }
         else
          {
            GetComponent<PostProcessingBehaviour>().profile = drunkProfile;
          }

        /*
        // SWITCH TO TEST EFFECT - TO DELETE IN FINAL VERSION
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
            */

    }
}
