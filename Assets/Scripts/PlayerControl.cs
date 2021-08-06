using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject paddle;
    public float MoveSpeed = 10.0f;
    public Rigidbody2D body2D;
    public float boundY = 3.0f;
    public string axis = "Vertical";
    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = body2D.velocity;
        velocity.y = 0;

        if (Input.GetAxisRaw(axis) > 0.0f)
        {
            velocity.y = MoveSpeed;
        }

        if (Input.GetAxisRaw(axis) < 0.0f)
        {

            velocity.y = -MoveSpeed;
        }

        body2D.velocity = velocity;

        Vector3 position = transform.position;

        if (position.y > boundY)
        {
            position.y = boundY;
        }

        if (position.y < -boundY)
        {
            position.y = -boundY;
        }

        transform.position = position;
    }
}
