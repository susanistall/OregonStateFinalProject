using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	public float speed = 0.05f;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                speed = -0.05f;
            }
            else if(speed < 0)
            {
                speed = 0.05f;
            }
            Vector2 offset = new Vector2(Time.time * speed, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
	}
}
