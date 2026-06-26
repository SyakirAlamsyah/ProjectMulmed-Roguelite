using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    Vector2 mdir;

    void inputmanagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        mdir = new Vector2(moveX, moveY).normalized;
    }

    void move()
    {
        rb.velocity = new Vector2(mdir.x * speed, mdir.y * speed);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputmanagement();
    }

    void FixedUpdate()
    {
        move();
    }
}
