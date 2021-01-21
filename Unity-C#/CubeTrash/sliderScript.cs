using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderScript : MonoBehaviour
{

    public Slider slider;

    public float FillSpeed = 0.25f;

    private bool isMousePressed = false;

    public GameObject sliderObject;

    public goal Goal;



    
    

    


    void Update()
    {

        if (slider.value == 1)
        {
            sliderObject.SetActive(false);
        }

        
        
        if (Input.GetMouseButtonUp(0))
        {
            isMousePressed = false;
        }

        if (isMousePressed)
        {
            slider.value += FillSpeed * Time.deltaTime * -20;
        }
        else
        {
            slider.value += FillSpeed * Time.deltaTime * 3;
        }



        if (Goal.goalHit == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isMousePressed = true;
                sliderObject.SetActive(true);
            }
        }






    }

    //  slider.value += FillSpeed * Time.deltaTime;

    


}
