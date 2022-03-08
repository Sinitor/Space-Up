using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float _score;
    private float _poinPerSeconds; 

    public Text scoreText;
    public Text highScore;

    private void Start()
    {
        _score = 0;
        _poinPerSeconds = 1;
        highScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");
    }

    private void Update()
    {
        scoreText.text = "Score: " + (int)_score;
        _score += _poinPerSeconds * Time.deltaTime;

        if ((int)_score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", (int)_score);
        }
    }
}
