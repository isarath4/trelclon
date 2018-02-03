using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardComponent : MonoBehaviour 
{

	public Text contentText;
	public EventObject boardClicked;
	public int index;
//	Board board;
	public IntObject selectedIndex;

	public void Setup(Board board)
	{
		contentText.text = board.content;
		index = board.index;
//		this.board = board;
	}

	public void OnClick()
	{
		selectedIndex.value = index; 
		boardClicked.Fire ();
	}
}
