using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;

    public WaveSystemScript waveSystemScript;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        UpdateScoreCount();
    }

    void UpdateScoreCount()
    {
        scoreText.text = score.ToString();
    }
}
