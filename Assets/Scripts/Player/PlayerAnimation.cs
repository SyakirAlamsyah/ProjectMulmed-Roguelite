using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator am;
    PlayerMove pm;
    SpriteRenderer sr;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMove>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.mdir.x != 0 || pm.mdir.y != 0)
        {
            am.SetBool("Move", true);
        }
        else
        {
            am.SetBool("Move", false);
        }

        spritedircheck();
    }

    void spritedircheck ()
    {
        if (pm.lasthorizontal < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}
