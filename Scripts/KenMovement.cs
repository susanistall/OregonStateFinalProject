using UnityEngine;
using System.Collections;

public class KenMovement : MonoBehaviour {

    public float swim = 15.0f;
    public float walk = 1.0f;
    private Rigidbody2D body;
    public float isGroundedRayLength = 0.75f;
    public float distanceToGround;
    public LayerMask layerMaskForGrounded;
    private Animator a;
    public AudioClip offScreenSound;
    private AudioSource aSource;
    private GameObject movingBlock;
    public AudioClip swimSound;

    // Use this for initialization
    void Start () {
        movingBlock = GameObject.FindGameObjectWithTag("movingBlock");
        body = GetComponent<Rigidbody2D>();
        a = GetComponent<Animator>();
        aSource = GetComponent<AudioSource>();
        //s = body.constraints = RigidbodyConstraints2D.
        //c = collider.center;
        // distanceToGround = body.bounds.extents.y;
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y < -5.0f || (movingBlock.transform.position.y >= 3 && transform.position.x > 34 && transform.position.x < 38 && transform.position.y >= 4))
        {
            if (offScreenSound)
            {
                AudioSource.PlayClipAtPoint(offScreenSound, transform.position);
                Destroy(gameObject);
            }
        }
        a.Play("swim");
        moveSwim();
	}

    void moveSwim ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * 0.03f);// * Time.time);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * 0.03f);// * Time.time);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * swim);
            
            AudioSource.PlayClipAtPoint(swimSound, transform.position);
        }
    }
}
