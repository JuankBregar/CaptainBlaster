using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOver;
    public int userScore = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore()
    {
        userScore++;
        scoreText.text = userScore.ToString();
    }

    public void playerDied()
    {
        gameOver.enabled = true;
        Time.timeScale = 0;
    }
}