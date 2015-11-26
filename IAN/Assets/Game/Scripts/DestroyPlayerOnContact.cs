using UnityEngine;
using System.Collections;

public class DestroyPlayerOnContact : MonoBehaviour {

    public GameObject enemyExplosion;
    public GameObject playerExplosion;
    public GameObject player;
    private GameManager gM;

    void Start()
    {
        GameObject gMObj = GameObject.FindGameObjectWithTag("GameController");
        gM = gMObj.GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (enemyExplosion != null && other.tag == "Player")
        {
            return;
        }
        
        if (other.tag == "Enemy")
        {
            gM.endGame = true;
            Instantiate(enemyExplosion, other.transform.position, other.transform.rotation);
            Instantiate(playerExplosion, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            Destroy(player);
        }

    }

}
