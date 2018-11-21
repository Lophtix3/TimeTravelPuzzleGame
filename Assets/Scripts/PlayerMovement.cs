using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    

    // Use this for initialization
    void Start ()
    {
        
    }



    void LogPosition(Vector3 _pos)
    {

    }

    void Move()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            transform.position += new Vector3(0f, 0f, 1f) * Input.GetAxisRaw("Vertical");
        }

        if (Input.GetButtonDown("Horizontal"))
        {
            transform.position += new Vector3(1f, 0f, 0f) * Input.GetAxisRaw("Horizontal");
        }

        LogPosition(transform.position);
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        Move();
    }
}
