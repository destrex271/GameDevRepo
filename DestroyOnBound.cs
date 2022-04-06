using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBound : MonoBehaviour
{
    private float zBound = 40.0f;

    private float lowBound = -10.0f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -zBound || transform.position.z > zBound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowBound)
        {
            Debug.Log("GameOver!");
            Destroy(gameObject);
        }
    }
}
