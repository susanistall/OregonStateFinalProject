using UnityEngine;
using System.Collections;

public class Ceiling : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(GameManager.cam.transform.position.x - transform.position.x, 0, 0));
    }
}
