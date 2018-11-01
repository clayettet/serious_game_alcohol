using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcoholLevel : MonoBehaviour {

    [Range(0.0f, 1.0f)]
    public float level;

	// Use this for initialization
	void Start () {
        //level = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (level > 0.5f) //is Drunk
        {
            //Camera cam = Camera.main;
            //if (cam != null)
           // {
                transform.position = transform.position + new Vector3(Mathf.Sin(Time.time * level*2) / 100, 0.0f, Mathf.Sin(Time.time * level*2)/2 / 100);
           //}
        }
    }
}
