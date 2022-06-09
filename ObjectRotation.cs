using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
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

    [SerializeField] private float RotSpeedFirst = 1.0F;
    [SerializeField] private float RotSpeedSecond = 1.0F;

    [SerializeField] private float MinFirst = -1.0F;
    [SerializeField] private float MaxFirst = 360.0F;
    [SerializeField] private float MinSecond = -1.0F;
    [SerializeField] private float MaxSecond = 360.0F;

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
        Vector2 rotate = mapping.Object.Cross.ReadValue<Vector2>();

        //applying old input system
        bool oldRotateLeft = false;
        bool oldRotateRight = false;
        oldRotateLeft = Input.GetButton("Bkey");
        oldRotateRight = Input.GetButton("Akey");
        ///////////////////////////
        if (XFirst == true)
        {
            if((rotate[1] == 1 || oldRotateLeft == true) && ModelFirst.eulerAngles.x <= MaxFirst)
            {   
                ModelFirst.Rotate(RotSpeedFirst, 0, 0, Space.Self);
            }
            if ((rotate[1] == -1 || oldRotateRight == true) && ModelFirst.eulerAngles.x >= MinFirst)
            {
                ModelFirst.Rotate(-RotSpeedFirst, 0, 0, Space.Self);
            }
        }
        if (YFirst == true)
        {
            if ((rotate[1] == 1 || oldRotateLeft == true) && ModelFirst.eulerAngles.y <= MaxFirst)
            {
                ModelFirst.Rotate(0, RotSpeedFirst, 0, Space.Self);
            }
            if ((rotate[1] == -1 || oldRotateRight == true) && ModelFirst.eulerAngles.y >= MinFirst)
            {
                ModelFirst.Rotate(0, -RotSpeedFirst, 0, Space.Self);
            }
        }
        if (ZFirst == true)
        {
            if ((rotate[1] == 1 || oldRotateLeft == true) && ModelFirst.eulerAngles.z <= MaxFirst)
            {
                ModelFirst.Rotate(0, 0, RotSpeedFirst, Space.Self);
            }
            if ((rotate[1] == -1 || oldRotateRight == true) && ModelFirst.eulerAngles.z >= MinFirst)
            {
                ModelFirst.Rotate(0, 0, -RotSpeedFirst, Space.Self);
            }
        }
        if (XSecond == true)
        {
            if ((rotate[0] == -1 || oldRotateRight == true) && ModelSecond.eulerAngles.x <= MaxSecond)
            {
                ModelSecond.Rotate(RotSpeedSecond, 0, 0, Space.Self);
            }
            if ((rotate[0] == 1 || oldRotateLeft == true) && ModelSecond.eulerAngles.x >= MinSecond)
            {
                ModelSecond.Rotate(-RotSpeedSecond, 0, 0, Space.Self);
            }
        }
        if (YSecond == true)
        {
            if ((rotate[0] == -1 || oldRotateRight == true) && ModelSecond.eulerAngles.y <= MaxSecond)
            {
                ModelSecond.Rotate(0, RotSpeedSecond, 0, Space.Self);
            }
            if ((rotate[0] == 1 || oldRotateLeft == true) && ModelSecond.eulerAngles.y >= MinSecond)
            {
                ModelSecond.Rotate(0, -RotSpeedSecond, 0, Space.Self);
            }
        }
        if (ZSecond == true)
        {
            if ((rotate[0] == -1 || oldRotateRight == true) && ModelSecond.eulerAngles.z <= MaxSecond)
            {
                ModelSecond.Rotate(0, 0, RotSpeedSecond, Space.Self);
            }
            if ((rotate[0] == 1 || oldRotateLeft == true) && ModelSecond.eulerAngles.z >= MinSecond)
            {
                ModelSecond.Rotate(0, 0, -RotSpeedSecond, Space.Self);
            }
        }
    }
    //==========================
}
