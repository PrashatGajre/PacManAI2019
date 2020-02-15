using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBehaviour : StateMachineBehaviour
{
    private Animator fsm = null;
    private Transform ghost;
    private Animator animator;
    private GhostController ghostController;
    [SerializeField] private _GhostBehaviour ghostBehaviour;
    [SerializeField] LeaveCondition leaveCondition;

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
            ghostController.fsm = fsm;
            ghostBehaviour = ghost.GetComponent<_GhostBehaviour>();
            leaveCondition = ghost.GetComponent<LeaveCondition>();
            if (animator == null || ghostBehaviour == null || ghostController == null)
            {
                Debug.LogError(this.name + " unable to find the parent component. Check the heirarchy of the GameObjects. The Parent should have: an Animator, a GhostController and a GhostBehaviour");
            }
        }
        ghostController.Respawn();
        ghostController.GetComponent<CircleCollider2D>().enabled = true;    //enable collider.
        GameDirector.Instance.addGhostAfraid(GhostAfraid);
        GameDirector.Instance.addGhostNotAfraid(GhostNotAfraid);
    }

    override public void OnStateUpdate(Animator fsm, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ghostController.moveToLocation = ghostBehaviour.getInitialPosition();
        if (leaveCondition != null)
        {
            if (leaveCondition.Evaluate())
            {
                fsm.SetBool("Chase", true);
            }
        }
    }

    override public void OnStateExit(Animator fsm, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    private void GhostAfraid()
    {
        fsm.SetBool("Afraid", true);
    }

    private void GhostNotAfraid()
    {
        fsm.SetBool("Afraid", false);
    }
}
