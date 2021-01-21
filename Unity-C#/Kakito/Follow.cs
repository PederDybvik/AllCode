using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    
    public Transform player;
    public float offset;


    
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, offset);
        //Posisjonen til kameraet, Settes til en Vector 3(3 dimensjoner, x, y og z),
        //består av x og y fra spilleren, og en float som settes i unity edditoren som er distansen kameraet er fra spilleren.
    }

}
