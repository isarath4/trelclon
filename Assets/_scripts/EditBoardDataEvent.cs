using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditBoardDataEvent : MonoBehaviour,IUIEvent 
{
	[SerializeField]BoardsObject boards;
	[SerializeField]IntObject selectedBoardIndex;
	[SerializeField]InputField editField;

	#region IUIEvent implementation
	public void Execute ()
	{
		boards.boards.boards [selectedBoardIndex.value].content = editField.text;
	}
	#endregion
}
