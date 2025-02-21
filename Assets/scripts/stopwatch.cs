using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class stopwatch : MonoBehaviour
{   
    public static stopwatch instance;
    public bool timeGoBrr = true;
    public float timeValue = 0;
    public Text timerText;

    public void Awake()
    {
        instance = this;
    }
   
    public void Update()
    {
        if (timeGoBrr == false)
        {
            return;
        }
        
            timeValue += Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(timeValue);
            timerText.text = time.ToString(@"mm\:ss\.ff");

            
        
    }

    public void EndTimer()
    {
        timeGoBrr = false;
        timerText.color = Color.cyan;
    }

}
