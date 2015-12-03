using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

    //Array of game objects called enemy
    public GameObject[] enemy;

    //Time between each spawn
    [SerializeField]
    private float spawnTime = 3f;

    //Position of spawning defined by an object with a transform
    public Transform[] spawnPoint;

    public GameManager gM;

    void Start()
    {
        //Repeat specified function in seconds after every spawnTime
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        //Creates a random variable which is a random game object in the array enemy
        int enemyIndex = Random.Range(0, enemy.Length);

        int spawnIndex = Random.Range(0, spawnPoint.Length);

        //Creates an enemy based on which ever random one was chosen. It's created at the transform spawnPoint's position and rotation
        Instantiate(enemy[enemyIndex], spawnPoint[spawnIndex].position, spawnPoint[spawnIndex].rotation);
    }

    void Update()
    {
        if (gM.endGame)
        {
            Destroy(gameObject);
        }
        if (gM.score >= 150 && gM.score < 250)
        {
            spawnTime = 2f;
        }
        if (gM.score >= 250)
        {
            spawnTime = 1f;
        }
    }

}
