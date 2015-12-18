using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Achievement : MonoBehaviour {

    public GameObject agentAch;
    public GameObject double0AgentAch;
    public GameObject bondAgentAch;

    void Start()
    {
        int agent = PlayerPrefs.GetInt("agent", 0);
        int double0Agent = PlayerPrefs.GetInt("double0Agent", 0);
        int bondAgent = PlayerPrefs.GetInt("bondAgent", 0);
        int highScore = PlayerPrefs.GetInt("highscore", 0);

        if (agent == 1 || highScore >= 150)
        {
            agentAch.GetComponent<RawImage>().color = Color.white;
        }
        else
        {
            agentAch.GetComponent<RawImage>().color = Color.red;
        }

        if (double0Agent == 1 || highScore >= 300)
        {
            double0AgentAch.GetComponent<RawImage>().color = Color.white;
        }
        else
        {
            double0AgentAch.GetComponent<RawImage>().color = Color.red;
        }

        if (bondAgent == 1 || highScore >= 600
            )
        {
            bondAgentAch.GetComponent<RawImage>().color = Color.white;
        }
        else
        {
            bondAgentAch.GetComponent<RawImage>().color = Color.red;
        }
    }

}
