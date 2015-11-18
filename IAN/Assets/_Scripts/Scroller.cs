using UnityEngine;
using System.Collections;

//This is based off of the Unity 2D Space Game
public class Scroller : MonoBehaviour
{
	public float scrollSpeed;
	public float tileSizeZ;

	private Vector3 startPosition;

	void Start ()
	{
        //Takes the object's position in the 3D world and saves it in the variable startPosition.
		startPosition = transform.position;
	}

	void Update ()
	{
        //This makes the object move to the next position based on whatever the scroll and tile speed is
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);//This will carry out the movement
		transform.position = startPosition - Vector3.forward * newPosition;//This will display the movement
	}
}