using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Transform player;
    public float speed;

    void Start()
    {
        player = FindObjectOfType<PlayerMove>().transform;
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}
