using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAvatarMovement : MonoBehaviour
{
    [SerializeField] private GameObject AvatarBody;
    [SerializeField] private GameObject AvatarCorrector;
    [SerializeField] private CharacterController AvatarCharCont;
    [SerializeField] private float Speed = 3.0f;

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
        Vector2 NewGo = mapping.Character.Movement.ReadValue<Vector2>();

        float OldGoSideways = Input.GetAxis("axisY");
        float OldGoFrontBack = Input.GetAxis("axisX");

        Vector3 OldDirection = (AvatarCorrector.transform.right * (-1) * OldGoSideways) + (AvatarCorrector.transform.forward * (-1) * OldGoFrontBack);
        AvatarCharCont.Move(OldDirection * Speed * Time.deltaTime * 2); //pomnożone razy dwa (dwa razy więcej klatek?)
        Vector3 NewDirection = (AvatarBody.transform.right * NewGo[0]) + (AvatarBody.transform.forward * NewGo[1]);
        AvatarCharCont.Move(NewDirection * Speed * Time.deltaTime);

        //dodatkowa pętla zwracająca postać na odpowiednią wysokość jeśli w wyniku kolizji został podniesiony w osi y
        //czy nie spowoduje wbijania się postaci w obiekty?
        if(this.transform.position.y != 2)
        {
            this.transform.position = new Vector3(this.transform.position.x, 2, this.transform.position.z);
        }
    }
}
