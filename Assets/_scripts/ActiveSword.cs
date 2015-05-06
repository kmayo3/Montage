using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActiveSword : MonoBehaviour {

    public Sprite empty;
    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;

    public Sprite active;

    SwordType activeSword;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        Image image = GetComponent<Image>();

        activeSword = Player.activeSword;

        if (activeSword == SwordType.Neutral)
        {
            image.sprite = sprite0;
        }
        else if (activeSword == SwordType.Fire)
        {
            image.sprite = sprite1;
        }
        else if (activeSword == SwordType.Energy)
        {
            image.sprite = sprite3;
        }
        else if (activeSword == SwordType.Shadow)
        {
            image.sprite = sprite2;
        }
        else if (activeSword == SwordType.Grand)
        {
            image.sprite = sprite4;
        }
        else
        {
            image.sprite = empty;
        }
	}
}
