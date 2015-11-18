using UnityEngine;
using System.Collections;

public class PauseButton : MonoBehaviour {

    private bool paused = false;
    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnButtonPress()
    {
        if (!paused)
        {
            paused = true;
        }
        else
        {
            paused = false;
        }

        //Toggle Time
        if (paused)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

}
