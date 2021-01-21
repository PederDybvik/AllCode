using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
      
    
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 90f);

        }
        if (Input.GetKey("d"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 270f);

        }
        if (Input.GetKey("w"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);

        }
        if (Input.GetKey("s"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 180f);

        }



        
        
    }
}
