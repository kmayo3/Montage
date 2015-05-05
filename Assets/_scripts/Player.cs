﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public static SwordType activeSword;

    public static float maxHealth = 10;
    public static float currentHealth = 5;

    public static float maxScrolls = 5;
    public static float currentScrolls = 3;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        // movement controls
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= speed * Time.deltaTime;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y -= speed * Time.deltaTime;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x += speed * Time.deltaTime;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y += speed * Time.deltaTime;
            this.transform.position = position;
        }

        // randomly pick a sword
        int rand = (int)Random.Range(0f, 5f);

        if (rand == 0)
        {
            activeSword = SwordType.Neutral;
        }
        else if (rand == 1)
        {
            activeSword = SwordType.Fire;
        }
        else if (rand == 2)
        {
            activeSword = SwordType.Shadow;
        }
        else if (rand == 3)
        {
            activeSword = SwordType.Energy;
        }
        else if (rand == 4)
        {
            activeSword = SwordType.Grand;
        }
    }

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Enemy") {
			currentHealth = currentHealth - 1;
		}
	}
}
