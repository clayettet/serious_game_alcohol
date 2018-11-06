using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + new Vector3(0.0f, 0.0f, Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f)/5); // drunk movement
    }
}
