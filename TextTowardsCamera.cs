using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class TextTowardsCamera : MonoBehaviour
{
    Camera cameraToLookAt;

    void Start()
    {
        cameraToLookAt = Camera.main;
    }

    void Update()
    {
        //transform.LookAt(cameraToLookAt.transform);
        transform.rotation = Quaternion.LookRotation(cameraToLookAt.transform.forward);
    }
}

