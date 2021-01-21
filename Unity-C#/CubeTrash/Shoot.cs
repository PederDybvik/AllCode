using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject cannonBall;
    public float respawnTime = 100f;
    public float timeLeft = 100f;

    public float offsetY = 2f;
    public float offsetX = 2f;

    private Vector2 spawnPosition;
    
    void Start()
    {
        timeLeft = respawnTime;
    }


    private void spawn()
    {
        spawnPosition = this.transform.position + new Vector3 (offsetX, offsetY, 0);
        GameObject a = Instantiate(cannonBall) as GameObject;
        a.transform.position = spawnPosition;
    }


    private void FixedUpdate()
    {
        if (timeLeft < 0)
        {
            spawn();
            timeLeft = respawnTime;
        }
        else
        {
            timeLeft = timeLeft - 1;
        }
        
    }

    






}
