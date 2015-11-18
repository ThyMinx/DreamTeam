using UnityEngine;
using System.Collections;

public class OpenGame : MonoBehaviour {

public void LoadGameLevel ()
{
    //Debug.Log("loaded");
    Application.LoadLevel(Application.loadedLevel + 1);
}

}

