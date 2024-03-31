using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public float speed = 5;
    public Transform startPos;
    public Transform endPos;
    Rigidbody2D rb;
    public Color myColor;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = myColor;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(EnemyMoving());
    }

    private void Update()
    {
        
    }
    public virtual IEnumerator EnemyMoving()
    {
        float time = 0;

        while (time < 1)
        {

            rb.transform.position = Vector3.Lerp(startPos.position, endPos.position, time);

            time += Time.deltaTime * speed;
            
            
            yield return StartCoroutine(EnemyMoving1());
        }
        Debug.Log("Coroutine 1");
        
    }

    public virtual IEnumerator EnemyMoving1()
    {
        float time = 1;

        while (time > 0)
        {

            rb.transform.position = Vector3.Lerp(endPos.position, startPos.position, time);

            time -= Time.deltaTime * speed;

            yield return null;
        }
        Debug.Log("Coroutine 2");
    }

    IEnumerator isHit()
    {
        
            spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(1);

        spriteRenderer.color = myColor;
;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(isHit());    
    }

}
