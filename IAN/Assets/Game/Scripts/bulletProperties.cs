using UnityEngine;
using System.Collections;

public class bulletProperties : MonoBehaviour {

    public float destroyTime = 3.5f;

    void Update()
    {
        destroyTime = destroyTime - Time.deltaTime;
        if (destroyTime <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

}
