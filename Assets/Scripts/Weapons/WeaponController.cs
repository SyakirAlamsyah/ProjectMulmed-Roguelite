using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Weapon Controller

public class WeaponController : MonoBehaviour
{

    [Header("Weapon Stats")]
    public WeapScriptableObj weaponData;
    float currentCooldown;


    protected PlayerMove pm;
    
    protected virtual void Start()
    {
        pm = FindObjectOfType<PlayerMove>();
        currentCooldown = weaponData.CooldownDuration; //At the start set the current cd to be the cd duration
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
        currentCooldown = weaponData.CooldownDuration; //Reset the cooldown 
    }
}
