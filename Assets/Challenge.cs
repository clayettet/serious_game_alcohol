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

    [Header("Sounds")]
    public AudioClip EndSound;

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
            else //on challenge end
            {
                IsInGame = false; //stop game
                PlaySound(EndSound); //audio feedback
                ScoreDisplay.text = Score.ToString(); //display score
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
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

    public static void PlaySound(AudioClip clip)
    {
        GameObject Go = new GameObject();
        AudioSource audioSource = Go.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();
        GameObject.Destroy(Go, audioSource.clip.length + 0.1f);
    }
}
