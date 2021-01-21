using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLives : MonoBehaviour
{
    public int lives = 1;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerAttack")
        {
            lives = lives - 1;
        }
    }

    private void Update()
    {
        if (lives < 1)
        {
            Destroy(gameObject);
        }
    }



}
