using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragIndicatorScript : MonoBehaviour
{

    Vector3 startPos;
    Vector3 endPos;
    public Camera cam;
    public LineRenderer lr;

    Vector3 camOffset = new Vector3(0, 0, 5);

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            lr.enabled = true;
            lr.positionCount = 2;
            startPos = cam.ScreenToWorldPoint(Input.mousePosition) + camOffset;
            lr.SetPosition(0, startPos);
            lr.useWorldSpace = true;
        }
        if (Input.GetMouseButton(0))
        {
            endPos = cam.ScreenToWorldPoint(Input.mousePosition) + camOffset;
            lr.SetPosition(1, endPos);
        }
        if (Input.GetMouseButtonUp(0))
        {
            lr.enabled = false;
        }


    }
}
