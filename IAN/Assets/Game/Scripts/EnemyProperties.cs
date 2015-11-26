using UnityEngine;
using System.Collections;

public class EnemyProperties : MonoBehaviour {

    public float delay;

    public int nothing = 0;
    public float speed = 3f;

    public GameObject bullet;
    public GameObject enemy;

    private GameManager gM;

    public Transform spawnPoint;

    void Start()
    {
        GameObject gMObj = GameObject.FindGameObjectWithTag("GameController");
        gM = gMObj.GetComponent<GameManager>();
        delay = Random.Range(0, 3);
        InvokeRepeating("Shooting", 1, delay);
    }

    void Update()
    {
        delay = Random.Range(0, 3);
        enemy.transform.position += Vector3.back * (speed * Time.deltaTime);

        if (gM.endGame)
        {
            Destroy(gameObject);
        }
    }

    void Shooting()
    {
        Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        GetComponent<AudioSource>().Play();
    }

}
