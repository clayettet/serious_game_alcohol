using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcoholLevel : MonoBehaviour
{

    [Range(0.0f, 1.0f)]
    public static float level;

    // Use this for initialization
    void Start()
    {
        level = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Level" + level);
        if (level >= 0.5f) //is Drunk
        { 
            transform.position = transform.position + new Vector3(Mathf.Sin(Time.time)*Mathf.PerlinNoise(Time.time,0.0f)/20, 0.0f, Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20); // drunk movement
        }
    }
}
