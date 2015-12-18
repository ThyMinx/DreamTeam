using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

    public void OnStartButton()
    {
        Application.LoadLevel("Game");
    }

    public void OnAchievementsButton()
    {
        Application.LoadLevel("Achievements");
    }
    public void OnExitButton()
    {
        Application.Quit();
    }

    public void OnBackButton()
    {
        Application.LoadLevel("Menu");
    }
}


  

    
