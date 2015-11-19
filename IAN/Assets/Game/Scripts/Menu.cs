using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public void OnButtonPress()
    {
        Application.LoadLevel(Application.loadedLevel - 1);
    }
}
