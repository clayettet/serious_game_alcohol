using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcoholLevel : MonoBehaviour
{

    [Range(0.0f, 1.0f)]
    public static float level;  //level of alcohol

    private float changeMoveIn; //time counter to switch movment directions while drunk
    private bool switchMove;    //save in which direction the player is moving while drunk

    // Use this for initialization
    void Start()
    {
        level = 0.4f; //init variables
        changeMoveIn = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // if player press P, increase alcohol level
        {
            if (level >= 0.9f)
            {
                level = 1.0f;
            }
            else
            {
                level = level + 0.1f;
            }
        }

        if (Input.GetKeyDown(KeyCode.M)) // if player press m, decrease alcohol level
        {
            if (level <= 0.1f)
            {
                level = 0.0f;
            }
            else
            {
                level = level - 0.1f;
            }
        }


        if (level >= 0.5f) //if player is drunk
        {
            if (changeMoveIn <= 0.0f) //if timer counter is equal to 0
            {
                changeMoveIn = Random.RandomRange(1.0f, 5.0f);  // init it again
                switchMove = !switchMove;                       // and switch direction
            }
            if (switchMove) // move player randomly in the direction given by switchMove variable
            {
                transform.position = transform.position + new Vector3(Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20, 0.0f, Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20); // drunk movement
                changeMoveIn = changeMoveIn - Time.deltaTime;
            } else
            {
                transform.position = transform.position + new Vector3(-Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20, 0.0f, Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20); // drunk movement
                changeMoveIn = changeMoveIn - Time.deltaTime;
            }
        }
        Debug.Log(level);
    }
}
