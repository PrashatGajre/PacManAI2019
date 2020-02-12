using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatterBehaviour : StateMachineBehaviour
{
    private Animator fsm = null;
    private Animator animator;
    private GhostController ghostController;
    private _GhostBehaviour ghostBehaviour;

    override public void OnStateEnter(Animator fsm, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (this.fsm == null)
        {
            this.fsm = fsm;

            animator = fsm.transform.parent.GetComponent<Animator>();
            ghostController = fsm.transform.parent.GetComponent<GhostController>();
            ghostBehaviour = fsm.transform.parent.GetComponent<_GhostBehaviour>();
        }
    }

    override public void OnStateUpdate(Animator fsm, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateExit(Animator fsm, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
