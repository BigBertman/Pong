using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int playerScore = 0;
    public static int computerScore = 0;

    public GUISkin skin;

    GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void Score(string wallID)
    {
        if (wallID == "Right Wall")
        {
            playerScore++;
        }

        if (wallID == "Left Wall")
        {
            computerScore++;
        }
    }

    void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label(new Rect(Screen.width / 2.0f - 150.0f - 12.0f, 20.0f, 100.0f, 100.0f), "" + playerScore);
        GUI.Label(new Rect(Screen.width / 2.0f + 150.0f + 12.0f, 20.0f, 100.0f, 100.0f), "" + computerScore);
    }
}
