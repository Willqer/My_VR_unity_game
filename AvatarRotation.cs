using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarRotation : MonoBehaviour
{
    [SerializeField] private Transform Camera;
    private Transform Pad;

    void Start()
    {
        Pad = GetComponent<Transform>();
    }
    void Update()
    {
        float rotationY = Camera.eulerAngles.y;
        Pad.eulerAngles = new Vector3(Pad.eulerAngles.x, rotationY, Pad.eulerAngles.z);
        Pad.position = Camera.position;
    }
}
