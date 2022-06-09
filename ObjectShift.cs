using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShift : MonoBehaviour
{
    //==========================
    [SerializeField] private Transform ModelFirst;
    [SerializeField] private Transform ModelSecond;

    [SerializeField] private bool XFirst = false;
    [SerializeField] private bool YFirst = true;
    [SerializeField] private bool ZFirst = false;
    [SerializeField] private bool XSecond = false;
    [SerializeField] private bool YSecond = false;
    [SerializeField] private bool ZSecond = false;

    [SerializeField] private float ShiftSpeedFirst = 1.0F;
    [SerializeField] private float ShiftSpeedSecond = 1.0F;

    [SerializeField] private float MinFirst = -10.0F;
    [SerializeField] private float MaxFirst = 20.0F;
    [SerializeField] private float MinSecond = -10.0F;
    [SerializeField] private float MaxSecond = 20.0F;

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
    }
    void Update()
    {
        Vector2 shift = mapping.Object.Cross.ReadValue<Vector2>();

        //applying old input system
        bool oldShiftUp = false;
        bool oldShiftDown = false;
        oldShiftUp = Input.GetButton("Ckey");
        oldShiftDown = Input.GetButton("Dkey");
        //=========================
        
        if (XFirst == true)
        {
            if ((shift[1] == 1 || oldShiftUp == true) && ModelFirst.localPosition.x <= MaxFirst)
            {
                ModelFirst.Translate(ShiftSpeedFirst * Time.deltaTime, 0, 0, Space.Self);
            }
            if ((shift[1] == -1 || oldShiftDown == true) && ModelFirst.localPosition.x >= MinFirst)
            {
                ModelFirst.Translate(-ShiftSpeedFirst * Time.deltaTime, 0, 0, Space.Self);
            }
        }
        if (YFirst == true)
        {
            if ((shift[1] == 1 || oldShiftUp == true) && ModelFirst.localPosition.y <= MaxFirst)
            {
                ModelFirst.Translate(0, ShiftSpeedFirst * Time.deltaTime, 0, Space.Self);
            }
            if ((shift[1] == -1 || oldShiftDown == true) && ModelFirst.localPosition.y >= MinFirst)
            {
                ModelFirst.Translate(0, -ShiftSpeedFirst * Time.deltaTime, 0, Space.Self);
            }
        }
        if (ZFirst == true)
        {
            if ((shift[1] == 1 || oldShiftUp == true) && ModelFirst.localPosition.z <= MaxFirst)
            {
                ModelFirst.Translate(0, 0, ShiftSpeedFirst * Time.deltaTime, Space.Self);
            }
            if ((shift[1] == -1 || oldShiftDown == true) && ModelFirst.localPosition.z >= MinFirst)
            {
                ModelFirst.Translate(0, 0, -ShiftSpeedFirst * Time.deltaTime, Space.Self);
            }
        }
        if (XSecond == true)
        {
            if ((shift[0] == 1 || oldShiftUp == true) && ModelSecond.localPosition.x <= MaxSecond)
            {
                ModelSecond.Translate(ShiftSpeedSecond * Time.deltaTime, 0, 0, Space.Self);
            }
            if ((shift[0] == -1 || oldShiftDown == true) && ModelSecond.localPosition.x >= MinSecond)
            {
                ModelSecond.Translate(-ShiftSpeedSecond * Time.deltaTime, 0, 0, Space.Self);
            }
        }
        if (YSecond == true)
        {
            if ((shift[0] == 1 || oldShiftUp == true) && ModelSecond.localPosition.y <= MaxSecond)
            {
                ModelSecond.Translate(0, ShiftSpeedSecond * Time.deltaTime, 0, Space.Self);
            }
            if ((shift[0] == -1 || oldShiftDown == true) && ModelSecond.localPosition.y >= MinSecond)
            {
                ModelSecond.Translate(0, -ShiftSpeedSecond * Time.deltaTime, 0, Space.Self);
            }
        }
        if (ZSecond == true)
        {
            if ((shift[0] == 1 || oldShiftUp == true) && ModelSecond.localPosition.z <= MaxSecond)
            {
                ModelSecond.Translate(0, 0, ShiftSpeedSecond * Time.deltaTime, Space.Self);
            }
            if ((shift[0] == -1 || oldShiftDown == true) && ModelSecond.localPosition.z >= MinSecond)
            {
                ModelSecond.Translate(0, 0, -ShiftSpeedSecond * Time.deltaTime, Space.Self);
            }
        }
    }
    //==========================
}
