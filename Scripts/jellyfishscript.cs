using UnityEngine;
using System.Collections;

public class jellyfishscript : MonoBehaviour {

    public AudioClip jellyfishElectric;
    float loggedTime = 0;
    public GameObject lightningBolts;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if((Time.time) - 5 > loggedTime)
        {
            rainBolts();
            loggedTime = Time.time;
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            AudioSource.PlayClipAtPoint(jellyfishElectric, transform.position, 1.0f);
        }
    }

    void rainBolts()
    {
        Instantiate(lightningBolts, new Vector2(101, 2), Quaternion.identity);
        Instantiate(lightningBolts, new Vector2(102, 3), Quaternion.identity);
        Instantiate(lightningBolts, new Vector2(103, 1), Quaternion.identity);
    }
}
