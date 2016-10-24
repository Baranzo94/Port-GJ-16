using UnityEngine;
using System.Collections;

public class ExitScene : MonoBehaviour {

	void Update()
	{
		
			Cursor.visible = true;
		
	}
	public void ExitButton()
	{
		Application.Quit();
	}
}
