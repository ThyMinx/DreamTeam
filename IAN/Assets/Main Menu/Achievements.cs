using UnityEngine;
using System.Collections;

public class Achievements : MonoBehaviour {

public void LoadGameLevel ()
{
    //Debug.Log("loaded");
    Application.LoadLevel(Application.loadedLevel + 2);
}

}

