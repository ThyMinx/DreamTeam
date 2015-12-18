using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int score = 0;
    public int highScore = 0;
    public bool newHighScore = false;
    public int agent;
    public int double0Agent;
    public int bondAgent;
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
        Achievements();
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

    void Achievements()
    {
        agent = PlayerPrefs.GetInt("agent", 0);
        double0Agent = PlayerPrefs.GetInt("double0Agent", 0);
        bondAgent = PlayerPrefs.GetInt("bondAgent", 0);

        if (agent == 0 && score >= 150)
        {
            PlayerPrefs.SetInt("agent", 1);
        }
        if (double0Agent == 0 && score >= 300)
        {
            PlayerPrefs.SetInt("double0Agent", 1);
        }
        if (bondAgent == 0 && score >= 600)
        {
            PlayerPrefs.SetInt("bondAgent", 1);
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
