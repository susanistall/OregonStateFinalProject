using UnityEngine;
using System.Collections;

public class boltScript : MonoBehaviour {

    public AudioClip electrocute;
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
            AudioSource.PlayClipAtPoint(electrocute, transform.position, 1.0f);
        }
    }
}
