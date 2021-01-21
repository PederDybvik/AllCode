using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public goal goalScript;

    public Text timerText;
    private float startTime;
    private string minutes;
    private string seconds;
    public float t;

    private bool HaveTheTimerStarted = false;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        

        if (!HaveTheTimerStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                startTime = Time.time;
                HaveTheTimerStarted = true;
            }
        }
        else
        {

            if (goalScript.goalHit)
            {

            }
            else
            {
                t = Time.time - startTime;



                minutes = ((int)t / 60).ToString();
                seconds = (t % 60).ToString("f2");



                if (int.Parse(minutes) < 1)
                {
                    timerText.text = seconds;
                }
                else
                {
                    timerText.text = minutes + ":" + seconds;
                }
            }



            


        }  
        
    }


}
