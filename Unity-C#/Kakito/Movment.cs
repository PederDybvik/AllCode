using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public ParticleSystem dust;
    public Rigidbody2D rb;
    public float speed;
    public float orgSpeed;
    public Vector2 movement;
    public Animator animator;
    public bool run;
    public bool attackActive = false;
    public float attackTime = 100;
    public float orgAttackTime = 100;
    public SpriteRenderer spriRend;
    public float AttackAnimator;
    public float attackFloat;
    
    public float Retning;


    private void Start()
    {
        spriRend = GetComponent<SpriteRenderer>();
        attackTime = orgAttackTime;
    }

    void Update()
    {

        if (Input.GetButtonDown("Jump") & attackTime > orgAttackTime - 1)
        {
            attackActive = true;
            rb.AddForce(movement.x, movement.y, thrust * attackForce);
        }



        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = orgSpeed * 2;

            run = true;
        }
        else
        {
            speed = orgSpeed;
            run = false;
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        animator.SetFloat("Retning", Retning);
        animator.SetBool("attackActive", attackActive);
        animator.SetFloat("AttackAnimator", Retning);
        
        

        
        if (Input.GetKey("a"))
        {
            Retning = 1;

        }
        if (Input.GetKey("d"))
        {
            Retning = 2;

        }
        if (Input.GetKey("w"))
        {
            Retning = 3;

        }
        if (Input.GetKey("s"))
        {
            Retning = 4;

        }

    }



    private void FixedUpdate()
    {


        if (!attackActive)
        {
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
        else
        {
            rb.MovePosition(rb.position * speed);
        }


        if (Input.GetButtonDown("Jump") & attackTime > orgAttackTime - 1)
        {
            attackActive = true;
   
        }


        if (attackActive)
        {
            attackTime = attackTime - 1;
        }
        else
        {
            attackTime = orgAttackTime;
        }

        if (attackTime < 0)
        {
            attackActive = false;
          
        }


    }
    


}
