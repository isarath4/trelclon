using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExecuter : MonoBehaviour 
{
	IUIEvent uiEvent;

	void Start()
	{
		uiEvent = GetComponent<IUIEvent> ();
	}

	public void Execute()
	{
		uiEvent.Execute ();
	}
}
