using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20.0f;

    private float xBound = 12.0f;
    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x;
        if (posX < -xBound || posX > xBound)
        {
            int sign = (int) (posX / Math.Abs(posX));
            transform.position = new Vector3(sign * xBound, transform.position.y, transform.position.z);
        }
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * Time.deltaTime * speed);
    }
}
