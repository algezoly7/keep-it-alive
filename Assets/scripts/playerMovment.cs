using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerMovment : MonoBehaviour
{
    public float Speed = 1.0f;
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0f, 0f, Speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-Speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0f, 0f, -Speed * Time.deltaTime);
        }
    }
}
