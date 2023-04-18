using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryNode : EventNode
{
    public string cname;
    public string text;

    public override void OnEnter()
    {
        DialogueGraph dGraph = graph as DialogueGraph;
        dGraph.current = this;

        DialogueManager.instance.Text(cname, text);
    }
}
