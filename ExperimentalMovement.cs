using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentalMovement : MonoBehaviour
{
    [SerializeField] private GameObject AvatarBody;
    [SerializeField] private GameObject AvatarCam;
    [SerializeField] private CharacterController AvatarCharCont;
    [SerializeField] private float speed = 1.0f;

    private ControlsMap maping;
    //==========================
    private void OnEnable()
    {
        maping.Enable();
    }
    private void OnDisable()
    {
        maping.Disable();
    }
    //==========================
    private void Awake()
    {
        maping = new ControlsMap();
    }
    void Update()
    {

        Vector2 Go = maping.Character.Movement.ReadValue<Vector2>();

        float GoSideways = Input.GetAxis("axisY");
        float GoFrontBack = Input.GetAxis("axisX");

        Vector3 Direction = (AvatarCam.transform.right * (-1) * GoSideways) + (AvatarCam.transform.forward * (-1) * GoFrontBack);
        AvatarCharCont.Move(Direction * speed * Time.deltaTime);

        Vector3 NewDirection = (AvatarCam.transform.right * Go[0]) + (AvatarCam.transform.forward * Go[1]);
        AvatarCharCont.Move(NewDirection * speed * Time.deltaTime);
    }
}
