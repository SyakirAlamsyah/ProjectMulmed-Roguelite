using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    [HideInInspector]
    public float lasthorizontal;
    [HideInInspector]
    public float lastvertical;
    Rigidbody2D rb;
    [HideInInspector]
    public Vector2 mdir;
    [HideInInspector]
    public Vector2 lastMovedVector;

    void inputmanagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        mdir = new Vector2(moveX, moveY).normalized;

        if (mdir.x != 0)
        {
            lasthorizontal = mdir.x;
            lastMovedVector = new Vector2(lasthorizontal, 0f);
        }

        if (mdir.y != 0)
        {
            lastvertical = mdir.y;
            lastMovedVector = new Vector2(0f, lastvertical);
        }

        if (mdir.x != 0 && mdir.y != 0)
        {
            lastMovedVector = new Vector2(lasthorizontal, lastvertical);
        }
    }

    void move()
    {
        rb.velocity = new Vector2(mdir.x * speed, mdir.y * speed);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastMovedVector = new Vector2(1, 0f);
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
