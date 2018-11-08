using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour {

    public AlcoholLevel AlcoholLevelManager;
    public TextMesh hit;
    
    // Use this for initialization
	void Start () {
        hit.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (AlcoholLevel.level < 0.5f)
        {
            transform.position = transform.position + new Vector3(0.0f, 0.0f, Mathf.Sin(Time.time) / 10);
        }
        else
        {
            transform.position = transform.position + new Vector3(0.0f, 0.0f, Mathf.Sin(Time.time) * Mathf.PerlinNoise(Time.time, 0.0f) / 5);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        StartCoroutine(DisplayHit());

    }

    IEnumerator DisplayHit()
    {
        hit.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        hit.gameObject.SetActive(false);
    }
}
