using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayScore : MonoBehaviour {

    public GameManager gM;

    public Text scoreDisplay;
    public Text highscoreDisplay;
    public Text highscore1Display;

    void OnGUI()
    {
        scoreDisplay.text = "Your Score Was: " + gM.score;
        if (gM.newHighScore)
        {
            highscoreDisplay.text = "You Got A New Highscore!";
            highscore1Display.text = "The New Highscore is: " + PlayerPrefs.GetInt("highscore");
        }
        else
        {
            highscoreDisplay.text = "You Didn't Get A New Highscore!";
            highscore1Display.text = "The Highscore is: " + PlayerPrefs.GetInt("highscore");
        }
    }

}
