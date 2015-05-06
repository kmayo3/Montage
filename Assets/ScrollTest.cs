using UnityEngine;
using System.Collections;

public class ScrollTest : MonoBehaviour {
	public GUIText referencetotext;
	public bool hasCollided = false;
	public string labelText = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if (hasCollided ==true)
		{   
			//adjust text screen width and height here
			//(Screen.width - width of box)/2, (Screen.height - height of box)/2, Width, Height
			GUI.Box(new Rect((Screen.width - 500f)/2f,(Screen.height - 500)/2f,500f,500f),(labelText));
		}
	}
	
	void OnTriggerEnter2D(Collider2D c)
	{
		if(c.gameObject.tag == "Player") 
			
		{
			hasCollided = true;
			//adjust text here
			labelText = "Scroll Instructions Here \n Use new line character to create new lines";
			
		}
	}
	
	void OnTriggerExit2D(Collider2D other ){

		hasCollided = false;
		
	}
}
