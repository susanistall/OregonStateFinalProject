using UnityEngine;
using System.Collections;

public class movingBlock : MonoBehaviour {

    bool moveUp;

	// Use this for initialization
	void Start () {
        moveUp = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if(transform.position.y >= 3)
        {
            moveUp = false;
        }
        if(transform.position.y <= -3)
        {
            moveUp = true;
        }
        if(moveUp == true)
        {
            transform.Translate(Vector2.up * 0.03f);
        }
        else
        {
            transform.Translate(Vector2.down * 0.03f);
        }
	}
}
