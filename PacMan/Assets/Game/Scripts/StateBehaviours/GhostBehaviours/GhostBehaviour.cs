using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _GhostBehaviour : MonoBehaviour
{
    public abstract Vector3 ChaseMovement(Transform ghost, Transform pacman, Transform option = null);
    public abstract Vector3 ScatterMovement(Transform ghost, Transform target);
    public abstract Vector3 FrightenedMovement(Transform ghost);
}
