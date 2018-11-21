using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour {

    [Header("Gameplay")]
    [Range(10, 120)]
    public float ChallengeTime = 30;
    protected float TimeLeft;
    public int Score;
    private bool IsInGame;

    [Header("UI")]
    public TextMesh ScoreDisplay;

	// Use this for initialization
	void Start () {
        Score = 0;
        IsInGame = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (IsInGame)
        {
            if (TimeLeft > 0)
            {
                TimeLeft = TimeLeft - Time.deltaTime;
                ScoreDisplay.text = TimeLeft.ToString("F0"); //update score

            }
            else
            {
                IsInGame = false;
                ScoreDisplay.text = Score.ToString(); //update score
            }
        }
	}

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        TimeLeft = ChallengeTime;
        Score = 0;
        IsInGame = true;
    }

    public void AddScore()
    {
        if (IsInGame)
        {
            Score++;
        }
    }
}
