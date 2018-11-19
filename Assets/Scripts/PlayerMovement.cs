using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    int i = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (i == 10) {
            if (Input.GetAxisRaw("Vertical") != 0) {
                transform.position += new Vector3(0f, 0f, 1f) * Input.GetAxisRaw("Vertical");
                i = 0;
            }
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                transform.position += new Vector3(1f, 0f, 0f) * Input.GetAxisRaw("Horizontal");
                i = 0;
            }
        }
        if (i < 10) {
            i++;
        }
        print(i);
    }
}
