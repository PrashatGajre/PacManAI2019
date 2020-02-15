using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkyBehaviour : _GhostBehaviour
{
    public Transform runToPosition;
    public override Vector3 ChaseMovement(Transform ghost, Transform option = null)
    {
        return pacman.transform.position;
    }

    public override Vector3 FrightenedMovement(Transform ghost, Transform option = null)
    {
        if (!frightenedCondition.Evaluate(ghost, runToPosition))
        {
            return runToPosition.position;
        }
        else
        {
            return ghost.position;
        }
    }

    public override Vector3 ScatterMovement(Transform ghost, Transform target)
    {
        return cornerPosition;
    }
}
