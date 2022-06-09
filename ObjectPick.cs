using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPick : MonoBehaviour
{
    //==========================
    private ControlsMap mapping;
 
    [SerializeField] private GameObject Model;
 /*[SerializeField]*/private GameObject AvatarHand;
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
        AvatarHand = GameObject.Find("/AvatarActive/AvatarBody/RightHand");
        mapping = new ControlsMap();
        mapping.Object.Trigger.performed += context => Up();
    }
    void Update()
    {
        if (Input.GetButtonDown("UpTrigger"))
        {
            Up();
        }
    }
    //==========================
    void Up()
    {
        AvatarHand.SetActive(true);
        //Model.GetComponent<Rigidbody>().useGravity = false;
        Model.transform.position = AvatarHand.transform.position;
        Model.transform.eulerAngles = AvatarHand.transform.eulerAngles;
        Model.transform.parent = AvatarHand.transform;
        PutDownObject.SetActive(true);
    }
    //==========================
}
