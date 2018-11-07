using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcoholLevel : MonoBehaviour
{

    [Range(0.0f, 1.0f)]
    public static float level;
    private float changeMoveIn;
    private bool switchMove;

    // Use this for initialization
    void Start()
    {
        level = 0.4f;
        changeMoveIn = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(changeMoveIn);
        if (level >= 0.5f) //is Drunk
        {
            if (changeMoveIn <= 0.0f)
            {
                changeMoveIn = Random.RandomRange(1.0f, 5.0f);
                switchMove = !switchMove;
            }
            if (switchMove)
            {
                transform.position = transform.position + new Vector3(Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20, 0.0f, Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20); // drunk movement
                changeMoveIn = changeMoveIn - Time.deltaTime;
            } else
            {
                transform.position = transform.position + new Vector3(-Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20, 0.0f, Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 20); // drunk movement
                changeMoveIn = changeMoveIn - Time.deltaTime;
            }
        }
    }
}
