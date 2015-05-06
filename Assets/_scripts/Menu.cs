using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
    public Texture backgroundTexture;

    public float textPlacementY1;
    public float textPlacementY2;

    public float textPlacementX1;
    public float textPlacementX2;

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

        if(GUI.Button(new Rect(Screen.width*textPlacementX1, Screen.height * textPlacementY1,
            Screen.width * .5f, Screen.height * .1f), "PLAY GAME"))
        {
            Application.LoadLevel("gameplay");
        }
        if (GUI.Button(new Rect(Screen.width * textPlacementX2, Screen.height * textPlacementY2,
            Screen.width * .5f, Screen.height * .1f), "INSTRUCTIONS"))
        {
            Application.LoadLevel("Instructions");
        }
    }
}
