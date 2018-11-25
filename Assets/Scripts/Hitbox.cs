using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {

    public int state;
    public int factor;
    public Vector2 from;
    public Vector3 to;
    public bool teleport;

    public int[] partsLayer;
    public int playerLayer;

    public GameObject[] parts;
    public GameObject player;
    public GameObject hitboxes;

    private Vector2 direction;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay (Collider other) {
        direction = other.gameObject.GetComponent<PlayerMovement>().Move(state);
        if (teleport && direction == from) {
            for (int x = 0; x<parts.Length; x++) {
                parts[x].transform.position = new Vector3(-partsLayer[x]*factor, -partsLayer[x]*factor, partsLayer[x]*factor);
            }
            player.transform.position = new Vector3(-playerLayer * factor, -playerLayer * factor, playerLayer * factor) + to;
            hitboxes.transform.position = new Vector3(-playerLayer * factor, -playerLayer * factor, playerLayer * factor);
        }
    }
}
