using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAvatarRotation : MonoBehaviour
{
    [SerializeField] private GameObject AvatarBody;
    [SerializeField] private GameObject AvatarCam;
    [SerializeField] private GameObject AvatarCorrector;

    void Update()
    {
        //body updated
        AvatarBody.transform.eulerAngles = new Vector3(AvatarBody.transform.eulerAngles.x,
                                                       AvatarCam.transform.eulerAngles.y, 
                                                       AvatarBody.transform.eulerAngles.z);
        //corrector updated
        AvatarCorrector.transform.eulerAngles = new Vector3(AvatarBody.transform.eulerAngles.x,
                                                       AvatarCam.transform.eulerAngles.y + 30f,
                                                       AvatarBody.transform.eulerAngles.z);
    }
}
