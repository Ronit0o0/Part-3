using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject arrowPrefab;
    public Transform spawnPoint;
    public float delay = 0.2f;

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Invoke("SpawnArrow",delay);
        
    }

    void SpawnArrow()
    {
        Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}