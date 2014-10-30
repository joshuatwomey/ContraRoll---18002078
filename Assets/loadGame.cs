using UnityEngine;
using System.Collections;

public class loadGame : MonoBehaviour {
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			Application.LoadLevel ("play");
		}
	}
}
