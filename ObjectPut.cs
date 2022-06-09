using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPut : MonoBehaviour
{
    //==========================
    private ControlsMap mapping;

    [SerializeField] private GameObject Model;
 /*[SerializeField]*/private GameObject AvatarHand;
 /*[SerializeField]*/private GameObject Indicator;
    [SerializeField] private GameObject PutDownObject;
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
        mapping.Object.Trigger.performed += context => Down();
        AvatarHand = GameObject.Find("/AvatarActive/AvatarBody/RightHand");
        Indicator = GameObject.Find("/AvatarActive/AvatarBody/RightHand/Indicator");
    }
    void Update()
    {
        if (Input.GetButtonDown("UpTrigger"))
        {
            Down();
        }
    }
    //==========================
    void Down()
    {
        if (Indicator.transform.position.x <= 9.2 && Indicator.transform.position.x >= -4)
        {
            if (Indicator.transform.position.z <= 7.2 && Indicator.transform.position.z >= -7.2)
            {
                Model.transform.localPosition = new Vector3(0.29f, -1.057346f, 1.11f);//ten element ustawia się lokalnie WZGLĘDEM RĘKI, nie w zewnęrznynym układzie współrzędnych
                Model.transform.parent = null;
                //Model.GetComponent<Rigidbody>().useGravity = true;
                AvatarHand.SetActive(false);
                PutDownObject.SetActive(false);
            }    
        }
    }
}
