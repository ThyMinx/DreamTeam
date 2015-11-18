using UnityEngine;
using System.Collections;

public class Bullet_Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.up * speed;
	}
}
