using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FrightenedCondition : Condition
{
    public abstract bool Evaluate(Transform self, Transform target);
}
