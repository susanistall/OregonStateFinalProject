using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {

    private Transform target;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetTarget(Transform t)
    {
        target = t;
    }

    void LateUpdate()
    {
        if(target)
        {
            float x = target.position.x + 4;

            transform.position = new Vector3(x, 0, transform.position.z);
            
        }
    }
}
