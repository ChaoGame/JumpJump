using UnityEngine;
using System.Collections;

public class PlayerJoin : MonoBehaviour {
	//private KeyCode playerKey;
	//private string justInput;
	public GameObject player;
	public 

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (Input.anyKey) 
		//{
		//	justInput = Input.inputString.ToUpper();
		//	Debug.Log (justInput);
		//	KeyCode playerKey = (KeyCode)System.Enum.Parse (typeof(KeyCode), justInput);
		//	Debug.Log (playerKey);
		//}
		for (KeyCode keyCode = KeyCode.A; keyCode <= KeyCode.Z; keyCode++)

			{if (Input.GetKeyDown (keyCode)) 
				{
				Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity);
				Debug.Log("User pressed key [" + keyCode + "]");
				}



			}



	}
}
