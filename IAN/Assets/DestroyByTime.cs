using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

    public float waitTime;

    void Update()
    {
        waitTime = waitTime - Time.deltaTime;

        if (waitTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
