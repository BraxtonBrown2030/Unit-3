using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    
    [SerializeField] private Camera thisCamera;
    public Transform player;
    public BoolTrigger deathmenu;

    void Start()
    {
        
        

    }

    void Update()
    {

        if(deathmenu == false)
        {
         this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        }
        
        if(deathmenu == true)
        {

            player.transform.position = new Vector3( this.transform.position.x, this.transform.position.y, -10);

        }   

    }
}
