using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Henchman1 : EnemyMovement
{
    private int Target1Points = 3;
    public override void PointOnHit()
    {
        finalScore += Target1Points;
    }
}
