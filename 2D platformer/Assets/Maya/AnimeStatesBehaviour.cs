using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimeStatesBehaviour : StateMachineBehaviour
{
     public UnityEvent onEnterEvent;
    public UnityEvent onUpdateEvent;
    public UnityEvent onExitEvent;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        onEnterEvent.Invoke();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        animator.SetBool("isDead", true);
        
        onUpdateEvent.Invoke();
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        onExitEvent.Invoke();
    }
    
}
