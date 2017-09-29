using UnityEngine;
using System.Collections;

public class endLevel : MonoBehaviour {

    public AudioClip subSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            AudioSource.PlayClipAtPoint(subSound, transform.position, 1.0f);
        }
    }
}
