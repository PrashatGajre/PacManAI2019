using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkyLeaveCondition : LeaveCondition
{
    public bool checkPelletCount = true;
    public int pelletsRemaining = 0;
    public override bool Evaluate()
    {
        if (checkPelletCount)   //If condition to check pellets. Add other conditions as and when necessary.
        {
            if (GameDirector.Instance.pelletsParent.childCount < pelletsRemaining)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}