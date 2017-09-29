using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {

    public float swim = 100.0f;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	    if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * 0.01f * Time.time);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * 0.01f * Time.time);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * swim);
            
        }
    }
}
