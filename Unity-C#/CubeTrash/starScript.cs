using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starScript : MonoBehaviour
{




    public TimerScript timerScript;

    private float time;

    public float OneStar;
    public float TwoStar;
    public float TreeStar;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public goal Goal;

    public bool Star1;
    public bool Star2;
    public bool Star3;

    public string thisIsLevel;

    public int LevelScore;


    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt(thisIsLevel, 0);
    }

    // Update is called once per frame
    void Update()
    {

        time = timerScript.t;


        if (time < OneStar && Goal.goalHit == true)
        {
            star1.SetActive(true);
            Star1 = true;
        }
        else
        {
            star1.SetActive(false);
            Star1 = false;
        }

        if (time < TwoStar && Goal.goalHit == true)
        {
            star2.SetActive(true);
            Star2 = true;
        }
        else
        {
            star2.SetActive(false);
            Star2 = false;
        }

        if (time < TreeStar && Goal.goalHit == true)
        {
            star3.SetActive(true);
            Star3 = true;
        }
        else
        {
            star3.SetActive(false);
            Star3 = false;
        }

        if (Star1)
        {
            LevelScore = 1;
        }
        
        if (Star1 && Star2)
        {
            LevelScore = 2;
        }

        if (Star1 && Star2 && Star3)
        {
            LevelScore = 3;
        }

        
        


        if (Goal.goalHit == true)
        {
            if (PlayerPrefs.GetInt(thisIsLevel, 0) < LevelScore)
            {
                PlayerPrefs.SetInt(thisIsLevel, LevelScore);
            }
            
        }








    }
}
