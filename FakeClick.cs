using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

public class FakeClick : MonoBehaviour
{
    [SerializeField] private GameObject Button;

    void Update()
    {
        if (Input.GetButton("UpTrigger"))
        {
            ExecuteEvents.Execute<IPointerClickHandler>(Button, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
        }
    }
}
