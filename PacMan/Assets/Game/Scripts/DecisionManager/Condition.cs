using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A base class for a logical element that can be evaluated.
abstract public class Condition : MonoBehaviour
{
    abstract public bool Evaluate();
}
