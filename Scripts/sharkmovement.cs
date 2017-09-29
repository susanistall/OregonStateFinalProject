using UnityEngine;
using System.Collections;

public class sharkmovement : MonoBehaviour {

    private float startingX;
    private float startingY;
    public bool up;
    private bool moveUp;
    public bool left;
    public AudioClip chompSound;
    // Use this for initialization
    void Start () {
        startingX = transform.position.x;
        startingY = transform.position.y;
        left = GetComponent<SpriteRenderer>().flipX;
        moveUp = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if(!up)
        {
            GetComponent<SpriteRenderer>().flipX = left;
            if (transform.position.x <= startingX - 5)
            {
                left = false;    
            }
            else if(transform.position.x >= startingX + 5)
            {
                left = true;
            }
            move();
        }
        else //up and down shark
        {
            if (transform.position.y >= 3)
            {
                moveUp = false;
            }
            else if(transform.position.y <= -3)
            {
                moveUp = true;
            }
            moveVert();
        }
	}

    void moveVert()
    {
        if(moveUp)
        {
            transform.Translate(Vector2.up * 0.04f);
        }
        else
        {
            transform.Translate(Vector2.down * 0.04f);
        }
    }

    void move()
    {
        if (left)
        {
            transform.Translate(Vector2.left * 0.06f);
        }
        else
        {
            transform.Translate(Vector2.right * 0.06f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            AudioSource.PlayClipAtPoint(chompSound, transform.position, 1.0f);
        }
    }
}
