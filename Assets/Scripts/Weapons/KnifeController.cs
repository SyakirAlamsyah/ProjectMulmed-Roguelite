using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : WeaponController
{


    protected override void Start()
    {
        base.Start();
    }


    protected override void attack()
    {
        base.attack();
        GameObject spawnedKnife = Instantiate(prefab);
        spawnedKnife.transform.position = transform.position;
        spawnedKnife.GetComponent<KnifeBehavior>().Direction(pm.lastMovedVector);
    }
}
