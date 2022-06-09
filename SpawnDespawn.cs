using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDespawn : MonoBehaviour
{
    //==========================
    [SerializeField] GameObject Lamp;
    Transform UpperTripod;
    Transform Head;
    [SerializeField] GameObject Light;
    [SerializeField] float PositionBufferZ = 0f;
    [SerializeField] GameObject Hand;

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
        UpperTripod = Lamp.transform.Find("UpperTripod");
        Head = UpperTripod.Find("Head");
        mapping = new ControlsMap();
        mapping.Object.Trigger.performed += context => Spawning();
    }
    void Update()
    {
        if (Input.GetButtonDown("UpTrigger"))
        {
            Spawning();
        }
    }
    //==========================
    void Spawning()
    {
        //spawning
        if (Lamp.transform.position.x == -9f)
        {
            Lamp.transform.position = new Vector3(-5f, 0f, PositionBufferZ);
        }
        else if (!Hand.activeSelf)//despawning, warunek konieczny, by nie przeniosło lampy wciąż przywiązanej do avatara
        {
            Lamp.transform.position = new Vector3(-9f,0f,PositionBufferZ);
            Lamp.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            UpperTripod.localPosition = new Vector3(0f, 0f, 0f);
            Head.rotation = Quaternion.Euler(0f, -180f, 90f);
            Light.SetActive(false);
        }
    }
}
