using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Weapon Controller

public class WeaponController : MonoBehaviour
{

    [Header("Weapon Stats")]
    public WeapScriptableObj weaponData;
    public GameObject prefab;
    public float damage;
    public float speed;
    public float cooldownDuration;
    float currentCooldown;
    public int pierce;
    protected PlayerMove pm;
    
    protected virtual void Start()
    {
        pm = FindObjectOfType<PlayerMove>();
        currentCooldown = cooldownDuration; //At the start set the current cd to be the cd duration
    }

    
    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime; 
        if(currentCooldown <= 0f) 
        {
            attack();
        }
    }

    protected virtual void attack()
    {
        currentCooldown = cooldownDuration; //Reset the cooldown 
    }
}
