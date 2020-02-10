using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Statement
{
    public Condition condition;
    public Response response;
};

public class DecisionManager : MonoBehaviour
{
    public List<Statement> statements;

    void Start()
    {

    }

    private void DecisionManagerUpdate()
    {
        foreach (Statement s in statements)
        {
            if (s.condition.Evaluate())
            {
                s.response.Dispatch();
            }
        }
    }

    void Update()
    {
        DecisionManagerUpdate();
    }
}

