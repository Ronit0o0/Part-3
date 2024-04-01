using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TMP_Text showHighscore;
    // Start is called before the first frame update
    void Start()
    {
        float currentHighscore = PlayerPrefs.GetFloat("HighScore", 0);

        showHighscore.text = "HighScore :" + showHighscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
