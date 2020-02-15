using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyBehaviour : _GhostBehaviour
{
    public Transform transform1;
    public Transform transform2;
    public override Vector3 ChaseMovement(Transform ghost, Transform option = null)
    {
        Vector3 finalPosition = pacman.transform.position + ((Vector3)pacman.MoveDirections[(int)pacman.moveDirection] * 4);
        return finalPosition;
    }

    public override Vector3 FrightenedMovement(Transform ghost, Transform option = null)
    {
        if (frightenedCondition.Evaluate(ghost, transform1))
        {
            return transform1.position;
        }
        else
        {
            return transform2.position;
        }
    }

    public override Vector3 ScatterMovement(Transform ghost, Transform target)
    {
        return cornerPosition;
    }
}
