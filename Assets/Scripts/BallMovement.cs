using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D body2D;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        Invoke("RandomStart", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RandomStart()
    {
        float rand = Random.Range(0, 2);

        if (rand < 1.0f)
        {
            body2D.AddForce(new Vector2(20.0f, -15.0f));

        }
        else
        {
            body2D.AddForce(new Vector2(-20.0f, -15.0f));
        }
    }

    void ResetBall()
    {
        body2D.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void ResetGame()
    {
        ResetBall();
        Invoke("RandomStart", 2.0f);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 velocity;
            velocity.x = body2D.velocity.x;
            velocity.y = (body2D.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            body2D.velocity = velocity;
        }
    }
}
