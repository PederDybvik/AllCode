using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    public Vector2 retning;
    public float timer = 200;
    public float speed;
    public Vector2 variasjon;
    private float itIs;
    public Animator animator;
    
    void FixedUpdate()
    {

        transform.position = new Vector3(transform.position.x + retning.x * speed, transform.position.y + retning.y * speed, transform.position.z);

        if (timer > itIs)
        {
            retning.x = Random.Range(-0.0002f, 0.0002f);
            retning.y = Random.Range(-0.0002f, 0.0002f);
        }
        if (timer > -5 & timer < 5)
        {
            retning = new Vector2(0, 0);
        }
        if (timer < -49)
        {
            timer = Random.Range(variasjon.x, variasjon.y);
            itIs = timer - 2;
        }

        timer = timer - 1;
        animator.SetFloat("Horizontal", retning.x * 10000);
    }


}
