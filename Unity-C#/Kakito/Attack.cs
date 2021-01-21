using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public GameObject Player;
    public Vector2 offset;
    public PolygonCollider2D pc2D;
    public bool attackActive = false;
    public float attackTime = 100;
    public bool attackActiveABC;
    public Transform PlaOr;


    

    private Movment playerLivesB;



    private Movment MovmentB;

    private void Start()
    {
        playerLivesB = Player.GetComponent<Movment>();
    }

    void Update()
    {

        attackActiveABC = playerLivesB.attackActive;

        if (attackActiveABC)
        {
            pc2D.enabled = true;
        }
        else
        {
            pc2D.enabled = false;
        }

        

        if (Input.GetKey("w"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            offset = new Vector2(0, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 180f);
            offset = new Vector2(0, -0.1f);
        }
        if (Input.GetKey("a"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 90f);
            offset = new Vector2(-0.1f, -0.1f);
        }
        if (Input.GetKey("d"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 270f);
            offset = new Vector2(0.1f, -0.1f);
        }


        if (Input.GetButtonDown("Jump") & attackTime > 9)
        {
            attackActive = true;
        }


        transform.position = PlaOr.position;







    }



    


}
