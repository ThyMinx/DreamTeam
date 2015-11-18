using UnityEngine;
using System.Collections;

public class shotMovement : MonoBehaviour {

    public float speed = 0.5f;
    public GameObject bullet;

	void Update () 
    {
        bullet.transform.position += Vector3.forward * speed;
	}
}
