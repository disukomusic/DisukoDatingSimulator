using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;
using XNode;

public class StoryEvent : Node {

	[Input] public Empty PreviousEvent;
	[Output] public DialogueStep NextEvent;

	public DialogueStep dialogue;

	// Use this for initialization
	protected override void Init() {
		base.Init();
		
	}

	public void NextStep() 
	{
		DialogueGraph dgraph = graph as DialogueGraph;

		NodePort exitPort = GetOutputPort("NextEvent");

		//dgraph.currentEvent = exitPort.Connection.GetConnection(GetNextStoryNode()).node as StoryEvent;
	}
}
[Serializable]
public class Empty 
{

}
//I will explain my reasoning later, for now it is what it is.
[Serializable]
public class DialogueData
{
	public string name;
	public string dialogue;
}
[Serializable]
public class CharacterData
{
	public Charachter character;
	public Position position;

	public bool isActive;
	public int EmotionalState;
}

[Serializable]
public class DialogueOptions
{
	public List<string> Questions;
}

[Serializable]
public class DialogueStep
{
	public DialogueData Dialogue;
	public List<CharacterData> Characters;
	public DialogueOptions options;
}
