using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwitch : MonoBehaviour
{
    [SerializeField] private GameObject Turning;

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
        mapping.Object.Trigger.performed += context => TurnOnOff();
    }
    void Update()
    {
        if (Input.GetButtonDown("UpTrigger"))
        {
            TurnOnOff();
        }
    }
    //==========================
    void TurnOnOff()
    {
        Turning.SetActive(!Turning.activeSelf);
    }
}
