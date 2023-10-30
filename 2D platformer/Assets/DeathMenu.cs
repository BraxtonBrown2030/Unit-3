using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeathMenu : MonoBehaviour
{
    
    public BoolTrigger deathmenuTrigger;
    public Canvas deathmenu;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(deathmenuTrigger == true)
        {

            gameObject.SetActive(true);

        }

        if(deathmenuTrigger == false)
        {

            

        }


    }
}
