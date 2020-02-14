using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GhostState { Home, Chase, Scatter, Frightened, Dead };
public abstract class _GhostBehaviour : MonoBehaviour
{
    public GhostState currentState = GhostState.Home;
    public abstract Vector3 ChaseMovement(Transform ghost, Transform pacman, Transform option = null);
    public abstract Vector3 ScatterMovement(Transform ghost, Transform target);
    public abstract Vector3 FrightenedMovement(Transform ghost);
}
