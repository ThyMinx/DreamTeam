using UnityEngine;
using System.Collections;

public class EnemyWeapon : MonoBehaviour {

    public GameObject bullet;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", delay, fireRate);
	}
	
	// Update is called once per frame
	void Fire () {
        Instantiate(bullet, shotSpawn.position, (shotSpawn.rotation));
        GetComponent<AudioSource>().Play();
	}
}
