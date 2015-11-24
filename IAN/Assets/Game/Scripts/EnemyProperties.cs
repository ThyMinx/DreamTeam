using UnityEngine;
using System.Collections;

public class EnemyProperties : MonoBehaviour {

    public float delay;

    public int nothing = 0;
    public float speed = 3f;

    public GameObject bullet;
    public GameObject enemy;

    public Transform spawnPoint;

    void Start()
    {
        delay = Random.Range(0, 3);
        InvokeRepeating("Shooting", 1, delay);
    }

    void Update()
    {
        delay = Random.Range(0, 3);
        enemy.transform.position += Vector3.back * (speed * Time.deltaTime);
    }

    void Shooting()
    {
        Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        GetComponent<AudioSource>().Play();
    }

}
