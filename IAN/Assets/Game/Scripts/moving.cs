using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class moving : MonoBehaviour {

    private bool moveLeft;
    private bool moveRight;

    public GameObject player;
    public float speed = 1f;
 
    void Update()
    {
        if(moveLeft && !moveRight)
            player.transform.position += Vector3.left * speed;
 
        if(moveRight && !moveLeft)
            player.transform.position += Vector3.right * speed;
    }
 
    public void MoveMeLeft()
    {
        moveLeft = true;
    }
 
    public void StopMeLeft()
    {
        moveLeft = false;
    }

    public void MoveMeRight()
    {
        moveRight = true;
    }

    public void StopMeRight()
    {
        moveRight = false;
    }
}
