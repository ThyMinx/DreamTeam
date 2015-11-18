using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
    // Has the game been paused?
    private bool isPaused;
    // Has the game gone through it's pause transition?
    private bool hasPaused = false;

    public void Start()
    {
        // Default to not paused.
        this.isPaused = false;
    }

    public void OnGUI()
    {
        // If you're paused
        if (this.isPaused)
        {
            GUI.Label(new Rect(203, 170, 60, 30), "PAUSED");
            if (GUI.Button(new Rect(200, 200, 60, 30), "Restart"))
            {
                Application.LoadLevel(Application.loadedLevel);
                this.changePauseState();
            }
            if (GUI.Button(new Rect(200, 230, 60, 30), "Resume"))
            {
                this.changePauseState();
            }
        
            // And nothing has initialized
            if (!this.hasPaused)
            {
                // Pause the game
                this.pauseGame();
                this.hasPaused = true;
            }
            // GUI changes.
        }
        else
        {
            if (this.hasPaused)
            {
                this.resumeGame();
                this.hasPaused = false;
            }
        }

        // If you click the button,
        if (GUI.Button(new Rect(430, 0, 25, 25), "II"))
        {
            // Toggle the games pause state.
            this.changePauseState();
        }

    }

    public void pauseGame()
    {
        // Pause the game
        Time.timeScale = 0;
        // Any other logic
    }

    public void resumeGame()
    {
        // Resume the game
        Time.timeScale = 1;
        // Any other logic
    }

    public void changePauseState()
    {
        // Alternate bool value per button click
        this.isPaused = !this.isPaused;
    }
}
