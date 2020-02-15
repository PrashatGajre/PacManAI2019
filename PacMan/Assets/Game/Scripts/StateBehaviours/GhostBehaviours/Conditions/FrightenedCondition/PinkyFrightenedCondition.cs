using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyFrightenedCondition : FrightenedCondition
{
    public override bool Evaluate()
    {
        throw new System.NotImplementedException();
    }

    public override bool Evaluate(Transform self, Transform target)
    {
        if (Vector3.Distance(self.position, target.position)>5)
        {
            return true;
        }
        else
            return false;
    }
}
