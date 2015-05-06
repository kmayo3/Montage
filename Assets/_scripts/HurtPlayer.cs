using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour 
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.currentHealth -= 1;
        }
    }
}
