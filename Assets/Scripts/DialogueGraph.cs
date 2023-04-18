using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

[CreateAssetMenu]
public class DialogueGraph : NodeGraph {

	public EventNode current;

	public void Continue() 
	{
		current.MoveNext();
	}
	public void Continue(int option)
	{
		current.MoveNext(option);
	}
}
