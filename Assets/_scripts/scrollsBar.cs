using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scrollsBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Image image = GetComponent<Image>();

        image.fillAmount = Player.currentScrolls / Player.maxScrolls;
	}
}
