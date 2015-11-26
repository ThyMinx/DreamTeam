using UnityEngine;
using System.Collections;

public class EnemyDestroyByContact : MonoBehaviour {

    public GameObject enemyExplosion;
    public GameObject playerExplosion;
    private GameManager gM;

    void Start()
    {
        GameObject gMObj = GameObject.FindGameObjectWithTag("GameController");
        gM = gMObj.GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (enemyExplosion != null && other.tag == "Enemy")
        {
            return;
        }

        if (playerExplosion != null && other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gM.endGame = true;
        }

        GetComponent<AudioSource>().Play();
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
