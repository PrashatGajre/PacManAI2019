using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeBehaviour : _GhostBehaviour
{
    [SerializeField] Vector3 initialPosition = new Vector3(0, 0, 0);
    [SerializeField] Vector3 cornerPosition = new Vector3(-8, 9, 0);

    public override Vector3 ChaseMovement(Transform ghost, Transform pacman, Transform option = null)
    {
        throw new System.NotImplementedException();
    }

    public override Vector3 FrightenedMovement(Transform ghost)
    {
        throw new System.NotImplementedException();
    }

    public override Vector3 ScatterMovement(Transform ghost, Transform target)
    {
        throw new System.NotImplementedException();
    }
}
