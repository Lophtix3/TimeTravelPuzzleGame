using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float currentVertical;
    private float currentHorizontal;
    private float vertical = 0;
    private float horizontal = 0;
    private Vector2 axis;

    // Use this for initialization
    void Start ()
    {
        
    }



    void LogPosition(Vector3 _pos)
    {

    }

    public Vector2 Move(int state)
    {
        vertical = Input.GetAxisRaw("Vertical");

        horizontal = Input.GetAxisRaw("Horizontal");

        if (currentHorizontal != horizontal || currentVertical != vertical) {
            switch (state) {
                case 1:
                    transform.position += new Vector3(horizontal, 0f, vertical);
                    break;
                case 2:
                    transform.position += new Vector3(horizontal, vertical, 0f);
                    break;

                case 3:
                    transform.position += new Vector3(0f, vertical, horizontal);
                    break;
                case 4:
                    transform.position += new Vector3(horizontal, -vertical, 0f);
                    break;
                case 5:

                    break;
            }
            LogPosition(transform.position);
            axis = new Vector2(horizontal, vertical);
            currentVertical = vertical;
            currentHorizontal = horizontal;
            return axis;
        }
        return new Vector2(0f, 0f);
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
    }
}
