using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatterBehaviour : StateMachineBehaviour
{
    private Animator fsm = null;
    private Transform ghost;
    private Animator animator;
    private GhostController ghostController;
    private _GhostBehaviour ghostBehaviour;

    override public void OnStateEnter(Animator fsm, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (this.fsm == null)
        {
            this.fsm = fsm;
            if (fsm == null)
            {
                Debug.LogError(this.name + " unable to find the FSM. Check the heirarchy of the GameObjects.");
            }
            ghost = fsm.transform.parent;
            animator = ghost.GetComponent<Animator>();
            ghostController = ghost.GetComponent<GhostController>();
            ghostBehaviour = ghost.GetComponent<_GhostBehaviour>();
            if (animator == null || ghostBehaviour == null || ghostController == null)
            {
                Debug.LogError(this.name + " unable to find the parent component. Check the heirarchy of the GameObjects. The Parent should have: an Animator, a GhostController and a GhostBehaviour");
            }
        }
        GameDirector.Instance.addGhostChase(GhostChase);
    }

    override public void OnStateUpdate(Animator fsm, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ghostController.moveToLocation = ghostBehaviour.ScatterMovement(ghost, ghostController.PacMan);                 
    }

    override public void OnStateExit(Animator fsm, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    private void GhostChase()
    {
        fsm.SetBool("Scatter", false);
        fsm.SetBool("Chase", true);
    }
}
