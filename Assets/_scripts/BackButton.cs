using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour 
{
    public float textPlacementY1;
    public float textPlacementY2;

    public float textPlacementX1;
    public float textPlacementX2;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width * textPlacementX1, Screen.height * textPlacementY1,
              Screen.width * .1f, Screen.height * .1f), "GO BACK "))
        {
            Application.LoadLevel("MainMenu");
        }
    }
}
