using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class goal : MonoBehaviour
{

    public int ThisIsLevel;

    public bool goalHit = false;
    public GameObject TapToContinueObject;

    public bool addShown = false;


    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            goalHit = true;
            TapToContinueObject.SetActive(true);
            PlayerPrefs.SetInt("onLevel", ThisIsLevel);
        }
    
    }


    void Update()
    {
        if (goalHit)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (addShown)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else
                {
                    Advertisement.Show();
                    addShown = true;
                }
                
                
            }
        }
        
    }


    
}