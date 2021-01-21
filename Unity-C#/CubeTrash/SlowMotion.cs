using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMotion : MonoBehaviour
{

    public goal Goal;

    public float SlowMotionVar = 0.1f;

    public Slider slider;
    
    void Update()
    {

        if (Goal.goalHit == false)
        {
            if (Input.GetMouseButton(0))
            {
                if (slider.value > 0)
                {
                    Time.timeScale = SlowMotionVar;
                }
                else
                {
                    Time.timeScale = 1f;
                }

            }
            else
            {
                Time.timeScale = 1f;
            }
        }


        
    }
}
