using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class EventNode : Node {

	[Input] public Empty enter;
	[Output] public Empty exit;
	[Output] public Empty exit1;
	[Output] public Empty exit2;
	[Output] public Empty exit3;

	public virtual void MoveNext()
	{
		DialogueGraph dGraph = graph as DialogueGraph;

		if (dGraph.current != this)
		{
			Debug.LogWarning("Node isn't active");
			return;
		}

		NodePort exitPort = GetOutputPort("exit");

		if (!exitPort.IsConnected)
		{
			Debug.LogWarning("Node isn't connected");
			return;
		}

		EventNode node = exitPort.Connection.node as EventNode;
		node.OnEnter();
	}
	public virtual void MoveNext(int option)
	{
		DialogueGraph dGraph = graph as DialogueGraph;

		if (dGraph.current != this)
		{
			Debug.LogWarning("Node isn't active");
			return;
		}

		NodePort exitPort = option == 0 ? GetOutputPort("exit") : GetOutputPort("exit" + option);

		if (!exitPort.IsConnected)
		{
			Debug.LogWarning("Node isn't connected");
			return;
		}

		EventNode node = exitPort.Connection.node as EventNode;
		node.OnEnter();
	}
	public virtual void OnEnter()
	{
		DialogueGraph dGraph = graph as DialogueGraph;
		dGraph.current = this;

		dGraph.Continue();
	}

	[Serializable]
	public class Empty { }
}