using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hart : MonoBehaviour
{




    public GameObject PlaYer;

    private PlayerLives playerLivesB;


    public float hartNumber;

    public float lives;

    public Image image;


    private void Start()
    {
        playerLivesB = PlaYer.GetComponent<PlayerLives>();
    }



    void Update()
    {


        lives = playerLivesB.playerLives;

        if (hartNumber > lives)
        {
            image.enabled = false;
        }
        else
        {
            image.enabled = true;
        }







    }
}
