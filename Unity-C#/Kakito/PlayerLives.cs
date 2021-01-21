using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{


    public float playerLives;




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            playerLives = playerLives - 1;
            
        }
        if (playerLives < 1)
        {
            Destroy(gameObject);
        }
    }


}
