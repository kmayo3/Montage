using UnityEngine;
using System.Collections;

public class Open : MonoBehaviour
{
    public GUIText referencetotext;

    //
    void OnTriggerEnter2D(Collider2D hit)
    {
        referencetotext.text = "Beware of the next area...";
    }

    //
    void OnTriggerExit2D(Collider2D hit)
    {
        referencetotext.text = "";
    }
}
