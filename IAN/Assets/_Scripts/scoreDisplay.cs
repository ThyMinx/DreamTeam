using UnityEngine;
using System.Collections;

public class scoreDisplay : MonoBehaviour {

    private int score;

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Score: " + score);
    }

    void OnGUI()
    {
        GUI.color = Color.white;

        GUI.Label(new Rect(10, 10, 100, 30), ("Score: " + score.ToString()));
    }
}
