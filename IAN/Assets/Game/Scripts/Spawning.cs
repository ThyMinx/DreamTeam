using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

    //Array of game objects called enemy
    public GameObject[] enemy;

    //Time between each spawn
    public float spawnTime = 3f;

    //Position of spawning defined by an object with a transform
    public Transform spawnPoint;

    void Start()
    {
        //Repeat specified function in seconds after every spawnTime
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        //Creates a random variable which is a random game object in the array enemy
        int enemyIndex = Random.Range(0, enemy.Length);

        //Creates an enemy based on which ever random one was chosen. It's created at the transform spawnPoint's position and rotation
        Instantiate(enemy[enemyIndex], spawnPoint.position, spawnPoint.rotation);
    }

}
