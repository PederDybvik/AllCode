using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{



    public Transform target;
    public Transform Camera;

    public float zOffset = -10f;
    public float xOffset = 5f;



    void FixedUpdate()
    {

        Camera.position = new Vector3(target.position.x + xOffset, 0, zOffset);
        //hei
    }
}
