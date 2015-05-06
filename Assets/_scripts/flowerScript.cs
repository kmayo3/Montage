using UnityEngine;
using System.Collections;

public class flowerScript : MonoBehaviour
{
    public GUIText referencetotext;
    public bool hasCollided = false;
    public string labelText = "";

    void OnGUI()
    {
        if (hasCollided == true)
        {
            //adjust text screen width and height here
            //(Screen.width - width of box)/2, (Screen.height - height of box)/2, Width, Height
            GUI.Box(new Rect((Screen.width - 500f) / 2f, (Screen.height - 500) / 2f, 500f, 500f), (labelText));
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            hasCollided = true;
            //adjust text here
            labelText = "Don't get too close to the fire... ";

        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        hasCollided = false;
        Destroy(this.gameObject);
        Player.currentScrolls += 1;
    }
}
