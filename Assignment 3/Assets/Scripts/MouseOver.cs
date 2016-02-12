using UnityEngine;
using System.Collections;

public class MouseOver : MonoBehaviour {

	public Texture2D newCursor;
	public Vector2 offset;


	void Start () {
		offset = new Vector2((newCursor.width * 0f), (newCursor.height * 0f));
	}
	

	void Update () {
	
	}

	public void mouseOverChange() { //Function used for mouseOver
		Cursor.SetCursor(newCursor, offset, CursorMode.Auto);
	}

	public void defaultMouse() { //Original mouse icon
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
	}

}
