using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
        transform.Translate( new Vector3(GameManager.cam.transform.position.x - transform.position.x, 0, 0));
	}
}
