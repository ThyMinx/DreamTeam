using UnityEngine;
using System.Collections;

public class Retry : MonoBehaviour {

    public void OnButtonPress()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
