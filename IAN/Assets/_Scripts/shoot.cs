using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public GameObject bullet;
    public Transform shotSpawn;
    public float fireRate;
    private float nextShot;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && Time.time > nextShot)
        {
            nextShot = Time.time + fireRate;
            Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play();
        }
	}
}
