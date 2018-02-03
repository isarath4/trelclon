using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupInputFieldEvent : MonoBehaviour,IUIEvent 
{
	public InputField inputField;
	[SerializeField]BoardsObject boardsRoot;
	[SerializeField]IntObject selectedIndex;

	#region IUIEvent implementation

	public void Execute ()
	{
		inputField.text = boardsRoot.boards.boards [selectedIndex.value].content;
	}

	#endregion
}
