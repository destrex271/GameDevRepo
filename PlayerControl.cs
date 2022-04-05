using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 20.0f;

    private float xBound = 12;
    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = transform.position.x;
        if (posX < -xBound || posX > xBound)
        {
            int sign = (int) (posX/Math.Abs(posX));
            transform.position = (new Vector3(sign * xBound, 0, 0));
        }
        
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * Time.deltaTime * speed);
    }
}
