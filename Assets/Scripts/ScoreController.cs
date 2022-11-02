using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    public void Start()
    {
        SetText();
    }

    public void Score()
    {
        score++;
        SetText();
    }

    public void SetText()
    {
        scoreText.text = "���� �մ� �� : " + score.ToString() + " / 9";
    }
}
