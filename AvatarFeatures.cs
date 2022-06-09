using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarFeatures : MonoBehaviour
{
    //==========================
    [SerializeField] private Transform PadCam;
    [SerializeField] private Transform PadMap;

    private ControlsMap mapping;
    //==========================
    private void OnEnable()
    {
        mapping.Enable();
    }
    private void OnDisable()
    {
        mapping.Disable();
    }
    //==========================
    private void Awake()
    {
        mapping = new ControlsMap();
        mapping.Character.Pads.performed += context => PadChange();
    }
    void Update()
    {
        if (Input.GetButtonDown("DownTrigger"))
        {
            PadChange();
        }
    }
    //==========================
    void PadChange()
    {
        Vector3 PositionBuffer = PadMap.position;
        PadMap.position = PadCam.position;
        PadCam.position = PositionBuffer;
    }
    //==========================
}
