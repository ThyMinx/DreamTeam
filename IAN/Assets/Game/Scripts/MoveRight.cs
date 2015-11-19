using UnityEngine;
using System.Collections;

public class MoveRight : MonoBehaviour {

    public GameObject player;
    public float speed = 1f;

    public void OnButtonDown()
    {
        player.transform.position += Vector3.right * speed;
    }

}
