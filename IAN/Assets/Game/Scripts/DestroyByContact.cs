using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

    public int scoreValue;
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
            Debug.Log("Hit Enemy");
            Debug.Log("BOOM!");
            Instantiate(enemyExplosion, transform.position, transform.rotation);
            gM.score += scoreValue;
        }

        if (playerExplosion != null && other.tag == "Player")
        {
            Debug.Log("Hit Player");
            Debug.Log("KABOOM!");
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
