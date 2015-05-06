using UnityEngine;
using System.Collections;

public class OpenScroll : MonoBehaviour 
{
    public GUIText referenceToText;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            referenceToText.text = "Beware of the next area...";
            Debug.Log("Why isnt this working????");
            Destroy(this.gameObject);
        }
    }
}
