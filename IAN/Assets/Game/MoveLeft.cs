using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {

    public GameObject player;
    public float speed = 1f;

    public void OnButtonDown()
    {
        player.transform.position += Vector3.left * speed;
    }

}
