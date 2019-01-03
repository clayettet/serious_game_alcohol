﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class AlcoholEffect : MonoBehaviour {

    [Header("Post-process profiles")]
    public PostProcessingProfile normalProfile;
    public PostProcessingProfile drunkProfile1;
    public PostProcessingProfile drunkProfile2;
    public PostProcessingProfile drunkProfile3;
    public PostProcessingProfile drunkProfile4;

    [Header("Alcohol Level Manager")]
    public AlcoholLevel AlcoholLevelManager;

    [Header("Sounds effects")]
    public AudioSource BackgroundSource;
    public AudioLowPassFilter LowFilter;

    [FMODUnity.EventRef]
    public string MusicLevel = "event:/backgroundmMusic";
    public FMOD.Studio.EventInstance BackgroundEvent;
    public FMOD.Studio.ParameterInstance AlcoholLevelMusic;

    // Use this for initialization
    void Start () {
        BackgroundEvent = FMODUnity.RuntimeManager.CreateInstance(MusicLevel);
        BackgroundEvent.getParameter("AlcoholLevelMusic", out AlcoholLevelMusic);
        BackgroundEvent.start();
    }
	
	// Update is called once per frame
	void Update () {
        ///////////////////////////////////// visual effects
        if (AlcoholLevel.level < 0.2f)
         {
            GetComponent<PostProcessingBehaviour>().profile = normalProfile;
            BackgroundSource.pitch = 1;
        }
        else if (AlcoholLevel.level <= 0.2f && AlcoholLevel.level < 0.4f)
        {
            GetComponent<PostProcessingBehaviour>().profile = drunkProfile1;
            BackgroundSource.pitch = 1;
        }
        else if (AlcoholLevel.level >= 0.4f && AlcoholLevel.level < 0.6f)
        {
            GetComponent<PostProcessingBehaviour>().profile = drunkProfile2;
            BackgroundSource.pitch = 1 - 0.07f * AlcoholLevel.level;
        }
        else if (AlcoholLevel.level >= 0.6f && AlcoholLevel.level < 0.8f)
        {
            GetComponent<PostProcessingBehaviour>().profile = drunkProfile3;
            BackgroundSource.pitch = 1 - 0.2f * AlcoholLevel.level;
        }
        else if (AlcoholLevel.level >= 0.8f)
          {
            GetComponent<PostProcessingBehaviour>().profile = drunkProfile4;
            BackgroundSource.pitch = 1 - 0.3f * AlcoholLevel.level;
        }

        //Debug.Log("Alcohol level: " + AlcoholLevel.level);
        LowFilter.cutoffFrequency = 5000 - AlcoholLevel.level * 3000; //actualise audio low filter 
        AlcoholLevelMusic.setValue(AlcoholLevel.level);
    }
}
