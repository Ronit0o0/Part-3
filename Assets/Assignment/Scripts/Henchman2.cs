using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Henchman2 : EnemyMovement
{
    private int Target2Points = 1;
    public override void PointOnHit()
    {
        finalScore += Target2Points;
    }
}
