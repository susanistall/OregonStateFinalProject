using UnityEngine;
using System.Collections;

public class jumping : MonoBehaviour {

    public float jumpHeight;
    public float multiplier;
    public AudioClip jumpsound;
    private AudioSource source;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            source.PlayOneShot(jumpsound);
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
        }
	}
}
