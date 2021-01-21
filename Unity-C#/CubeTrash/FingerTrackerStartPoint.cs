using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerTrackerStartPoint : MonoBehaviour
{
    public GameObject Finger;

    private Vector2 spawnPosition;

    public Camera cam;

    public void spawn()
    {
        GameObject a = Instantiate(Finger) as GameObject;
        a.transform.position = cam.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawn();
        }



    }


}
