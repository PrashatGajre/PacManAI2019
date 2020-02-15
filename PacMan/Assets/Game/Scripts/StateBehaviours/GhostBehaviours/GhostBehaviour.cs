using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GhostState { Home, Chase, Scatter, Frightened, Dead };

[System.Serializable]
public class BehaviourTime
{
    public GhostState ghostState;
    public float duration;

    public BehaviourTime(GhostState ghostState, float duration)
    {
        this.ghostState = ghostState;
        this.duration = duration;
    }
}
public abstract class _GhostBehaviour : MonoBehaviour
{
    protected PacmanController pacman;
    [SerializeField] protected Vector3 initialPosition;
    [SerializeField] protected Vector3 cornerPosition;
    public BehaviourTime[] behaviourTime;
    public GhostState currentState = GhostState.Home;
    public Transform dependentChaseTransform;
    public FrightenedCondition frightenedCondition;

    private void Start()
    {
        pacman = GameObject.FindObjectOfType<PacmanController>();
        if (behaviourTime == null || behaviourTime.Length == 0)
        {
            BehaviourTime[] bt = 
                {
                    (new BehaviourTime(GhostState.Scatter, 7.0f)),
                    (new BehaviourTime(GhostState.Chase, 20.0f)),
                    (new BehaviourTime(GhostState.Scatter, 7.0f)),
                    (new BehaviourTime(GhostState.Chase, 20.0f)),
                    (new BehaviourTime(GhostState.Scatter, 5.0f)),
                    (new BehaviourTime(GhostState.Chase, 20.0f)),
                    (new BehaviourTime(GhostState.Scatter, 5.0f)),
                    (new BehaviourTime(GhostState.Chase, 0.0f))
                };

            behaviourTime = bt;
        }
    }

    public Vector3 getInitialPosition() { return initialPosition; }
    public Vector3 getCornerPosition() { return cornerPosition; }
    public abstract Vector3 ChaseMovement(Transform ghost, Transform option = null);
    public abstract Vector3 ScatterMovement(Transform ghost, Transform target);
    public abstract Vector3 FrightenedMovement(Transform ghost, Transform option = null);
    
}
