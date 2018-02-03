using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardsGUIController : MonoBehaviour 
{
	Iserializer serializer;
	IDeserializer deserializer;
	IUIEvent uiEvent;
	[SerializeField]BoardsObject boards;

	// Use this for initialization
	void Start () 
	{
		serializer = GetComponent<Iserializer> ();
		deserializer = GetComponent<IDeserializer> ();
		deserializer.DeserializeSuccess += OnDeserialize;
		uiEvent = GetComponent<IUIEvent> ();
		deserializer.Deserialize ();
	}

	void OnDeserialize(string result)
	{
		boards.boards = JsonUtility.FromJson<Boards> (result);
		SetUpBoardData ();
	}

	public void SetUpBoardData()
	{
		uiEvent.Execute ();
	}

	public void SaveData()
	{
		serializer.Serialize (boards.boards);
	}
	
}
