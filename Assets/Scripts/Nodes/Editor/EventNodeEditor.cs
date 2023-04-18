using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using XNodeEditor;

[CustomNodeEditor(typeof(EventNode))]
public class DialogueEditor : NodeEditor
{
	public override void OnHeaderGUI()
	{
		GUI.color = Color.white;
		EventNode node = target as EventNode;
		DialogueGraph graph = node.graph as DialogueGraph;
		if (graph.current == node) GUI.color = Color.blue;
		string title = target.name;
		GUILayout.Label(title, NodeEditorResources.styles.nodeHeader, GUILayout.Height(30));
		GUI.color = Color.white;
	}

	public override void OnBodyGUI()
	{
		base.OnBodyGUI();
		EventNode node = target as EventNode;
		DialogueGraph graph = node.graph as DialogueGraph;

		if (GUILayout.Button("Set as current")) graph.current = node;
	}
}
