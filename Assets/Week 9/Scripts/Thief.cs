using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    float dashSpeed = 7;
    Coroutine dashing;
    protected override void Attack()
    {
        if (dashing != null) 
        {
            StopCoroutine(dashing);
            StopAllCoroutines();
        }
        dashing = StartCoroutine(Dash());
     
    }

    IEnumerator NotDash()
    {
        yield return null;
    }

    IEnumerator Dash()
    {
        //dash towards mouse
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = dashSpeed;
        while (speed > 3)
        {
            yield return null;
        }

        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(knifePrefab, spawnPoint1.position, spawnPoint1.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(knifePrefab, spawnPoint2.position, spawnPoint2.rotation);
            
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
    public override string ToString()
    {
        return "Hi, im the rogue";
    }
}
