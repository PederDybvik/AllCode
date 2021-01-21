using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingLayer : MonoBehaviour
{

    public int SortingLevelBase = 5000;
    public float offset = 10;
    public bool RunEverytime;

    private Renderer MyRenderer;



    private void Awake()
    {
        MyRenderer = gameObject.GetComponent<Renderer>();    
    }


    void Update()
    {
        MyRenderer.sortingOrder = (int)(SortingLevelBase - transform.position.y - offset);
        if (!RunEverytime)
        {
            Destroy(this);
        }
    }
}
