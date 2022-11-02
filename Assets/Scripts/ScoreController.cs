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
        scoreText.text = "³²Àº ¼Õ´Ô ¼ö : " + score.ToString() + " / 9";
    }
}
