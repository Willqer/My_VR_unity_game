using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookDown : MonoBehaviour
{
    [SerializeField] private Transform AvatarsView;
    [SerializeField] private float WalkingSpeed = 1.0F;
    [SerializeField] private float MinAngleToMove = 30.0F;

    private CharacterController charCont;

    private void Awake()
    {
        charCont = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if(AvatarsView != null) {
            if (AvatarsView.eulerAngles.x >= MinAngleToMove && AvatarsView.eulerAngles.x < 90)
            {
                Vector3 Direction = AvatarsView.TransformDirection(Vector3.forward);
                charCont.SimpleMove(WalkingSpeed*Direction);
            }
        }
    }
}
