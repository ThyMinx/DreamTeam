using UnityEngine;
using System.Collections;

public class PauseButton : MonoBehaviour {

    public bool paused = false;
    public GameObject pauseMenu;
    public GameManager gM;

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
            gM.Pause();
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        else
        {
            gM.Pause();
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        GetComponent<AudioSource>().Play();
    }

}
