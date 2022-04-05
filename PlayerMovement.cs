using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20.0f;
    private float xBound = 15.0f;
    
    // Prefabs
    public GameObject pizzaPrefab, steakPrefab;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * Time.deltaTime * speed);
        float posX = transform.position.x;
        if (posX < -xBound || posX > xBound)
        {
            int sign = (int) (posX / Math.Abs(posX));
            transform.position = new Vector3(sign * xBound, transform.position.y, transform.position.z);
        }

        if (Input.GetMouseButtonDown((int)MouseButton.LeftMouse))
        {
            Instantiate(pizzaPrefab, transform.position, pizzaPrefab.transform.rotation);
        }
        else if (Input.GetMouseButtonDown((int) MouseButton.RightMouse))
        {
            Instantiate(steakPrefab, transform.position, steakPrefab.transform.rotation);
        }
    }
}
