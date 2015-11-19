using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    //public GameObject[] enemies;
    //public Vector3 spawnValues;

    public int score = 0;
    public int highScore = 0;
    public bool newHighScore = false;
    public bool endGame = false;
    public GameObject gameOver;
    public GameObject gameStart;

    public Text scoreDisplay;

    void Start()
    {
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

}
