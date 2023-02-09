using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

[CreateAssetMenu]
public class DialogueGraph : NodeGraph {
	public StoryEvent currentEvent;

	public void NextEvent() 
	{
		currentEvent.NextStep();
	}
}