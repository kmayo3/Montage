using UnityEngine;
using System.Collections;

public class ShadowScript : MonoBehaviour
{
    public GUIText referencetotext;
    public bool collided = false;
    public string shadowtText = "";

    void OnGUI()
    {
        if (collided == true)
        {
            //adjust text screen width and height here
            //(Screen.width - width of box)/2, (Screen.height - height of box)/2, Width, Height
            GUI.Box(new Rect((Screen.width - 500f) / 2f, (Screen.height - 500) / 2f, 500f, 500f), (shadowtText));
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collided = true;
            //adjust text here
            shadowtText = "Obtaining each scroll gives a special powerup!";

        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        collided = false;
        Destroy(this.gameObject);
        Player.currentScrolls += 1;
    }
}
