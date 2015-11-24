using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int score = 0;
    public int highScore = 0;
    public bool newHighScore = false;
    public bool endGame = false;
    public GameObject gameOver;
    public GameObject gameStart;
    public bool paused = false;

    public Text scoreDisplay;

    void Start()
    {
        Time.timeScale = 1;
        gameStart.SetActive(true);
        gameOver.SetActive(false);
    }

    void Update()
    {
        if (endGame)
        {
            gameStart.SetActive(false);
            gameOver.SetActive(true);
            Comparison(score);
        }
    }

    void OnGUI()
    {
        scoreDisplay.text = "Score: " + score;
    }

    void Comparison(int newHighscore)
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);

        if (newHighscore > highScore)
        {
            newHighScore = true;
            PlayerPrefs.SetInt("highscore", newHighscore);
        }
    }

    public void Pause()
    {
        if (paused)
        {
            paused = false;
            Time.timeScale = 1;
        }
        else
        {
            paused = true;
            Time.timeScale = 0;
        }

    }

}
