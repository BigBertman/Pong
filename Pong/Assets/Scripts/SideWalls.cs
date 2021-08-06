using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ball")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            collision.gameObject.SendMessage("ResetGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
