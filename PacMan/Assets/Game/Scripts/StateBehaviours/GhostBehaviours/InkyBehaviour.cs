using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkyBehaviour : _GhostBehaviour
{

    public override Vector3 ChaseMovement(Transform ghost, Transform option = null)
    {
        Vector3 intermediatePosition = (pacman.transform.position + ((Vector3)pacman.MoveDirections[(int)pacman.moveDirection] * 2)) ;
        Vector3 finalPosition = (intermediatePosition - option.position) *2;
        return finalPosition;
    }

    public override Vector3 FrightenedMovement(Transform ghost, Transform option = null)
    {
        Transform pelletparent = GameDirector.Instance.pelletsParent;
        Transform randomPellet = pelletparent.GetChild(Random.Range(0, pelletparent.childCount));
        return randomPellet.position;
    }

    public override Vector3 ScatterMovement(Transform ghost, Transform target)
    {
        return cornerPosition;
    }
}
