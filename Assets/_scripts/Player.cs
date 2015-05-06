using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public static SwordType activeSword;

    public static float maxHealth = 10;
    public static float currentHealth = 10;

    public static float maxScrolls = 5;
    public static float currentScrolls = 0;

    public bool isInvuln = true;
    public int invulnFrames = 75;
    public int invulnRemaining = 50;

    // Use this for initialization
    void Start()
    {
    }

    void FixedUpdate()
    {
        if (isInvuln)
        {
            if (invulnRemaining <= 0)
            {
                isInvuln = false;
            }
            else
            {
                invulnRemaining--;
            }
            Blink();
        }
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
    }


	void OnCollisionEnter2D(Collision2D other)
    {
        // check for an enemy collision
		if (other.gameObject.tag == "Enemy") {
			currentHealth--;
            isInvuln = true;
            invulnRemaining = invulnFrames;
		}

        // check for variou swords
        if  (other.gameObject.tag == "NormalSword")
        {
            activeSword = SwordType.Neutral;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "FireSword")
        {
            activeSword = SwordType.Fire;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "ShadowSword")
        {
            activeSword = SwordType.Shadow;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "EnergySword")
        {
            activeSword = SwordType.Energy;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "MasterSword")
        {
            activeSword = SwordType.Grand;
            Destroy(other.gameObject);
        }

	}

    void Blink()
    {
        if (invulnRemaining % 3 == 0)
        {
            SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();
            sprite.color = Color.red;
        }
        else
        {
            SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();
            sprite.color = Color.white;
        }

        if (invulnRemaining <= 0)
            {
                SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();
                sprite.color = Color.white;
            }
        }
}
