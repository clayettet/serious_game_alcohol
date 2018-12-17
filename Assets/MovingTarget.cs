using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour {

    public AlcoholLevel AlcoholLevelManager;
    public TextMesh hit;
    private Vector3 InitialPosition;

    public Challenge ChallengeManager;
    
    // Use this for initialization
	void Start () {
        hit.gameObject.SetActive(false);
        InitialPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (AlcoholLevel.level < 0.5f)
        {
            transform.position = InitialPosition + new Vector3(0.0f, 0.0f, Mathf.Sin(Time.time) * 7);
        }
        else
        {
            transform.position = InitialPosition + new Vector3(0.0f, 0.0f, Mathf.Sin(Time.time + Mathf.PerlinNoise(Time.time, 0.0f)/1.5f) * 7);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        ChallengeManager.AddScore();
        StartCoroutine(DisplayHit());
    }

    IEnumerator DisplayHit()
    {
        hit.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        hit.gameObject.SetActive(false);
    }
}
