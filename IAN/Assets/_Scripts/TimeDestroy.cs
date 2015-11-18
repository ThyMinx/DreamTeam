using UnityEngine;
using System.Collections;

public class TimeDestroy : MonoBehaviour
{
	public float lifetime;

	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}
