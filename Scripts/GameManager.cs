using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public static GameCamera cam;

    // Use this for initialization
    void Start () {
        cam = GetComponent<GameCamera>();
        spawnPlayer();    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void spawnPlayer()
    {
        Object o = Instantiate(player, new Vector2(-4, 0), Quaternion.identity);
        cam.SetTarget((o as GameObject).transform);
    }
}
