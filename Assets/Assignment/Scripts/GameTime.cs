using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 

public class GameTime : MonoBehaviour
{
    private float timerDuration = 60;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timerDuration)
        {
            timer = 0;

            SceneManager.LoadScene("StartScreen");

        }
    }
}
