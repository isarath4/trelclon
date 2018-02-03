using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{
	Iserializer serializer;
	IDeserializer deserializer;

	[SerializeField]Board result=null,saveData=null;

	// Use this for initialization
	void Start () 
	{
		serializer = GetComponent<Iserializer> ();
		deserializer = GetComponent<IDeserializer> ();
		deserializer.DeserializeSuccess += OnDeserialized;
		serializer.SerializeSuccess += OnSerializeSuccess;
		serializer.SerializeFailed += OnSerializeFailed;
		deserializer.Deserialize ();
	}


	void Serialize()
	{
		serializer.Serialize (saveData);
	}

	void OnSerializeSuccess()
	{
		print ("Serialization success.");
	}

	void OnSerializeFailed()
	{
		print ("Serialization failed.");
	}

	void OnDeserialized(string jsonResponse)
	{
		result = JsonUtility.FromJson<Board> (jsonResponse);		
	}
}

[System.Serializable]
public class Board
{
	public string content;
}