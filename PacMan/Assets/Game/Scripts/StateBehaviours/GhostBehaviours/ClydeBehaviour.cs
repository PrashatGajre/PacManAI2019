using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeBehaviour : _GhostBehaviour
{

    public override Vector3 ChaseMovement(Transform ghost, Transform option = null)
    {
        if (Vector3.Distance(ghost.position, pacman.transform.position) > 8)
        {
            return pacman.transform.position;
        }
        else
        {
            return cornerPosition;
        }
    }

    public override Vector3 FrightenedMovement(Transform ghost, Transform option = null)
    {
        if (frightenedCondition.Evaluate(ghost, pacman.transform))
        {
            return pacman.transform.position;
        }
        else
        {
            return ghost.transform.position;
        }
    }

    public override Vector3 ScatterMovement(Transform ghost, Transform target)
    {
        return cornerPosition;
    }
}
