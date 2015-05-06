using UnityEngine;
using System.Collections;

public class lavaScroll : MonoBehaviour
{
    public GUIText referencetotext;
    public bool collides = false;
    public string text = "";

    void OnGUI()
    {
        if (collides == true)
        {
            //adjust text screen width and height here
            //(Screen.width - width of box)/2, (Screen.height - height of box)/2, Width, Height
            GUI.Box(new Rect((Screen.width - 500f) / 2f, (Screen.height - 500) / 2f, 500f, 500f), (text));
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collides = true;
            //adjust text here
            text = "Scroll Instructions Here \n Use new line character to create new lines";

        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        collides = false;
        Destroy(this.gameObject);
        Player.currentScrolls += 1;
    }
}