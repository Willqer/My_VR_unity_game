using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMovement: MonoBehaviour
{
    //==========================
    [SerializeField] private Transform AvatarsView;
    [SerializeField] private CharacterController charCont;
    [SerializeField] private float WalkingSpeed = 3.0F;

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
        if (AvatarsView != null) {
            Vector2 go = maping.Character.Movement.ReadValue<Vector2>();

            //applying old input system
            float oldGoSides = 0;
            float oldGoFront = 0;
            oldGoSides = Input.GetAxis("axisY");
            oldGoFront = Input.GetAxis("axisX");
            ///////////////////////////



            if (go[1] == 1 || oldGoFront == 1f)
            {

                Vector3 Direction = AvatarsView.TransformDirection(Vector3.forward);
                charCont.SimpleMove(WalkingSpeed * Direction);           
            }
            if (go[1] == -1 || oldGoFront == -1f)
            {
                Vector3 Direction = AvatarsView.TransformDirection(Vector3.back);
                charCont.SimpleMove(WalkingSpeed * Direction);
            }
            if (go[0] == -1 || oldGoSides == 1f)
            {
                Vector3 Direction = AvatarsView.TransformDirection(Vector3.left);
                charCont.SimpleMove(WalkingSpeed * Direction);
            }
            if (go[0] == 1 || oldGoSides == -1f)
            {
                Vector3 Direction = AvatarsView.TransformDirection(Vector3.right);
                charCont.SimpleMove(WalkingSpeed * Direction);
            }
        }
    }
    //==========================
}


