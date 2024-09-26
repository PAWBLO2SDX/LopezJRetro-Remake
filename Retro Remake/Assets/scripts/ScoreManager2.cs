using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager2 : MonoBehaviour
{
    public TMPro.TMP_Text score;
    public static int ScoreCount = 10;

    private int HighestScore = 1000;

    public string format = "";


    // Update is called once per frame
    void Update()
    {
        score.SetText(string.Format(format, HighestScore, ScoreCount));
        
    }
}
