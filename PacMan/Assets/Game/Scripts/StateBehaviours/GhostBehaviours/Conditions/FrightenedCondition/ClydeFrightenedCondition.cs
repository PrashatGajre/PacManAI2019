using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeFrightenedCondition : FrightenedCondition
{
    public override bool Evaluate()
    {
        throw new System.NotImplementedException();
    }

    public override bool Evaluate(Transform self, Transform target)
    {

        if (self == target)
        {
            return true;
        }
        else
            return false;
    }
}