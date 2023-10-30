using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Navbehavor : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform playertransfrom;
    
    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        agent.SetDestination(playertransfrom.position);

        
        
    }
}
