using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionNode : EventNode
{
    public Selection sel;
    public override void OnEnter()
    {
        DialogueGraph dGraph = graph as DialogueGraph;
        dGraph.current = this;

        DialogueManager.instance.GetNextScene(sel);
    }
}
