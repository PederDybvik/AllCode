using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movment : MonoBehaviour
{

    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    public LineRenderer lr;


    public goal Goal;
    

    Camera cam;
    Vector2 force;
    Vector3 startPos;
    Vector3 endPos;

    Vector3 startOfLine;
    Vector3 endOfLine;


    private void Start()
    {
        cam = Camera.main;

        
        
        



    }

    private void Update()
    {

        if (Goal.goalHit == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                lr.enabled = true;
                lr.positionCount = 2;
    
                startPos = cam.ScreenToWorldPoint(Input.mousePosition);
                startPos.z = 0;
            }
        
            if (Input.GetMouseButton(0))
            {
                startOfLine = this.transform.position;
                endOfLine = startPos - cam.ScreenToWorldPoint(Input.mousePosition) + this.transform.position;
               startOfLine.z = 0f;
                endOfLine.z = 0f;


                lr.SetPosition(0, startOfLine);
                lr.SetPosition(1, endOfLine);
               lr.useWorldSpace = true;

            }




            if (Input.GetMouseButtonUp(0))
            {
                lr.enabled = false;
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                endPos = cam.ScreenToWorldPoint(Input.mousePosition);
                endPos.z = 0;
    
                force = new Vector2(Mathf.Clamp(startPos.x - endPos.x, minPower.x, maxPower.x), Mathf.Clamp(startPos.y - endPos.y, minPower.y, maxPower.y));
                rb.AddForce(force * power, ForceMode2D.Impulse);
            }


        
        }
    }
}
