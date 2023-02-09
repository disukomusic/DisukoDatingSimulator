using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class SelectionNode : Node {

	[Input] public DialogueOptions PreviousEvent;
	[Output] public Empty NextEvent;

	public SelectionMode Mode;
	// Use this for initialization
	protected override void Init() {
		base.Init();
	}

	public void Continue() 
	{
		if (Mode == SelectionMode.Next) 
		{
			return;
		}
		//Wait for response
	}
}
public enum SelectionMode 
{
	Next = 0,
	Select = 1,
}