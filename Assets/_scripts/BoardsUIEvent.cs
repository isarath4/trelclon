using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardsUIEvent : MonoBehaviour,IUIEvent
{
	[SerializeField]BoardsObject boards=null;
	[SerializeField]BoardComponent boardPrefab=null;
	[SerializeField]Transform scrollParent=null;
	List<BoardComponent> boardComponents = new List<BoardComponent>();

	#region IUIEvent implementation

	public void Execute ()
	{
		Clear ();
		int i = 0;
		foreach (var v in boards.boards.boards) 
		{
			v.index = i;
			BoardComponent prefa = Instantiate<BoardComponent> (boardPrefab);
			prefa.transform.SetParent (scrollParent);
			prefa.transform.localScale = new Vector3 (1,1,1);
			prefa.transform.localPosition = new Vector3 (1,1,1);
			prefa.Setup (v);
			boardComponents.Add (prefa);
			i++;
		}
	}


	void Clear()
	{
		foreach (var v in boardComponents)
			Destroy (v.gameObject);
		boardComponents = new List<BoardComponent>();
	}

	#endregion
}
