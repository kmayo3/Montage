using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public static SwordType activeSword;

    public static float maxHealth = 10;
    public static float currentHealth = 10;

    public static float maxScrolls = 5;
    public static float currentScrolls = 0;

    public bool isInvuln = false;
    public int invulnFrames = 75;
    public int invulnRemaining = 0;

    public Sprite down_face;
    public Sprite left_face;
    public Sprite right_face;
    public Sprite up_face;

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
        Image image = this.GetComponent<Image>();

        // movement controls
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= speed * Time.deltaTime;
            this.transform.position = position;
            image.sprite = left_face;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y -= speed * Time.deltaTime;
            this.transform.position = position;
            image.sprite = down_face;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x += speed * Time.deltaTime;
            this.transform.position = position;
            image.sprite = right_face;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y += speed * Time.deltaTime;
            this.transform.position = position;
            image.sprite = up_face;
        }
    }

	void OnCollisionEnter2D(Collision2D other)
    {
        // check enemy collision
		if (other.gameObject.tag == "Enemy") {
			currentHealth--;
            isInvuln = true;
            invulnRemaining = invulnFrames;
		}

        // check sword collisions
        if (other.gameObject.tag == "NeutralSword")
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
        if (other.gameObject.tag == "GrandSword")
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
