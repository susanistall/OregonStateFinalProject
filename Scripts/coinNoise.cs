using UnityEngine;
using System.Collections;

public class coinNoise : MonoBehaviour {

    public AudioClip coinSound;
    private AudioSource aSource;
	// Use this for initialization
	void Start () {
        aSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        //aSource.PlayOneShot(coinSound);
        Destroy(gameObject);
    }
}
