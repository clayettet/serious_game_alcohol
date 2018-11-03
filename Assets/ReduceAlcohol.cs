using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceAlcohol : MonoBehaviour
{
    public AlcoholLevel AlcoholLevelManager;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        AlcoholLevel.level = AlcoholLevel.level - 0.1f;
    }
}
