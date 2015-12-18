using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CurrentHighscore : MonoBehaviour {

    public Text highscore;

    void Start()
    {
        int hs = PlayerPrefs.GetInt("highscore", 0);

        highscore.text = "Current Highscore: " + hs;
    }

}
