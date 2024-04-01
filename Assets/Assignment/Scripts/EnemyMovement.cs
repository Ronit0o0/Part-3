using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 5;
    public Transform startPos;
    public Transform endPos;
    Rigidbody2D rb;
    public Color myColor;
    SpriteRenderer spriteRenderer;
    public int score = 6;
    public TMP_Text scoreValue;
    protected static int finalScore = 0;
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
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreValue.text = "Score: " + finalScore;
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
        PointOnHit();
    }

    public virtual void PointOnHit()
    {
        finalScore += score;
        UpdateScore();
    }

    public static void MorePoints(int points)
    {
        finalScore += points;
    }
}
