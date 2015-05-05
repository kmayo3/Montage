using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Image image = GetComponent<Image>();

        image.fillAmount = Player.currentHealth / Player.maxHealth;
    }
}
