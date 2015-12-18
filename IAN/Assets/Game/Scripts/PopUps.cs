using UnityEngine;
using System.Collections;

public class PopUps : MonoBehaviour {

    public GameObject Ach1;
    public GameObject Ach2;
    public GameObject Ach3;
    public bool pop1 = false;
    public bool pop2 = false;
    public bool pop3 = false;

    void Update()
    {
        int a1 = PlayerPrefs.GetInt("agent", 0);
        int a2 = PlayerPrefs.GetInt("double0Agent", 0);
        int a3 = PlayerPrefs.GetInt("bondAgent", 0);

        if (a1 == 1)
        {
            pop1 = true;
            PopUp(Ach1);
        }
        if (a2 == 1)
        {
            pop2 = true;
            PopUp(Ach2);
        }
        if (a3 == 1)
        {
            pop3 = true;
            PopUp(Ach3);
        }

    }

    void PopUp(GameObject pop)
    {
        float time = 1f;
        while (time > 0)
        {
            time = Time.deltaTime - time;
            pop.transform.Translate(0, -5, 0);
        }
        
        time = 1f;
        while (time > 0)
        {
            time = Time.deltaTime - time;
            pop.transform.Translate(0, 5, 0);
        }
    }
}
