using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A logical element that runs when a condition requires it.
abstract public class Response : MonoBehaviour
{
    abstract public void Dispatch();
}
