using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyScriptableObj enemyData;
    Transform player;


    void Start()
    {
        player = FindObjectOfType<PlayerMove>().transform;
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, enemyData.MoveSpeed * Time.deltaTime);
    }
}
