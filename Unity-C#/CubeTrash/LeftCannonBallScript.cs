using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCannonBallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;


    void Start()
    {

        rb.velocity = new Vector2(-3, speed);

    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Tak" || col.gameObject.name == "Bakke")
        {
            Destroy(this.gameObject);
        }
    }
}
