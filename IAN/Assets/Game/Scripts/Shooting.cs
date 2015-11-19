using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject bullet;
    public float fireRate = 3;
    private float nextShot;

    private bool firing = false;

    public void OnButtonPress()
    {
        nextShot = Time.time + fireRate;
        Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        GetComponent<AudioSource>().Play();
    }

}
