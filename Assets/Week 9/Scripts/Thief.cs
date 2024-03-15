using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject swordPrefab;
    public Transform spawnPoint2;
    public float delay = 0.2f;

    protected override void Attack()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        base.Attack();
        Invoke("SpawnSword", delay);
    }

    void SpawnSword()
    {
        Instantiate(swordPrefab, spawnPoint2.position, spawnPoint2.rotation);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
