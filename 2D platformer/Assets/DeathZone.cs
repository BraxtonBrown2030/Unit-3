using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    
    public BoolTrigger deathmenu;
    public Canvas deathmenText;

    void Start()
    {

    deathmenu.setbool = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {

            Destroy(other.gameObject);
            deathmenu.setbool = true;
            deathmenText.GetComponent<Canvas>().enabled = true;
        }


    }

}
