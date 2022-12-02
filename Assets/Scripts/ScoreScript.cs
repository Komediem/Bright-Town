using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public int maxScore;

    public WaveSystemScript waveSystemScript;

    void Start()
    {
        score = 0;
        maxScore = 0;
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
