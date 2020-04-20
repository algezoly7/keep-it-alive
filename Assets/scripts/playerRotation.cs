using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotation : MonoBehaviour
{
    public Camera fpscamera;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = fpscamera.transform.rotation;
    }
}
