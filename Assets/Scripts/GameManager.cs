using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;

    public Text ScoreText;
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Updatescore()
    {
        score++;
        ScoreText.text=score.ToString();
    }
}
