using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRwH : MonoBehaviour
{
    [SerializeField] private GameObject Hardlight1;
    [SerializeField] private GameObject Hardlight2;
    [SerializeField] private GameObject Snoot1;
    [SerializeField] private GameObject Snoot2;
    [SerializeField] private GameObject Softbox1;
    [SerializeField] private GameObject Softbox2;
    [SerializeField] private GameObject Honeycomb1;
    [SerializeField] private GameObject Honeycomb2;
    [SerializeField] private GameObject Model;

    [SerializeField] private GameObject UpperHoneycomb1;
    [SerializeField] private GameObject UpperHoneycomb2;
    [SerializeField] private GameObject HeadHoneycomb1;
    [SerializeField] private GameObject HeadHoneycomb2;

    [SerializeField] private GameObject TestIndicatorX;
    [SerializeField] private GameObject TestIndicatorV;
    void Awake()
    {
        /*
        Hardlight1 = GameObject.Find("HrdLght1");
        Hardlight2 = GameObject.Find("HrdLght2");
        Snoot1 = GameObject.Find("Snoot1");
        Snoot2 = GameObject.Find("Snoot2");
        Softbox1 = GameObject.Find("Softbox1");
        Softbox2 = GameObject.Find("Softbox2");
        Honeycomb1 = GameObject.Find("HnyCmb1");
        Honeycomb2 = GameObject.Find("HnyCmb2");
        Model = GameObject.Find("Environment/Set/ModelRotator");

        TestIndicatorX = GameObject.Find("AvatarActive/AvatarBody/TestIndicatorX");
        TestIndicatorV = GameObject.Find("AvatarActive/AvatarBody/TestIndicatorV");

        UpperHoneycomb1 = GameObject.Find("HnyCmb1/UpperTripod");
        UpperHoneycomb2 = GameObject.Find("HnyCmb2/UpperTripod");
        HeadHoneycomb1 = GameObject.Find("HnyCmb1/UpperTripod/Head");
        HeadHoneycomb2 = GameObject.Find("HnyCmb2/UpperTripod/Head");
        */
    }
    void Update()
    {
        if (Hardlight1.transform.position.x <= -6 && Hardlight2.transform.position.x <= -6 &&
            Softbox1.transform.position.x   <= -6 && Softbox2.transform.position.x   <= -6 &&
            Snoot1.transform.position.x     <= -6 && Snoot2.transform.position.x     <= -6  )
        {
            //=================================================================================================
            //=================================================================================================
            //=================================================================================================
            if      (Honeycomb2.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y             >= 93   && Model.transform.eulerAngles.y             <= 103  &&
                     UpperHoneycomb1.transform.localPosition.y >= 18   && UpperHoneycomb1.transform.localPosition.y <= 21   &&
                     HeadHoneycomb1.transform.eulerAngles.z    >= 60   && HeadHoneycomb1.transform.eulerAngles.z    <= 80   &&
                     Honeycomb1.transform.position.x           >= 3    && Honeycomb1.transform.position.x           <= 3.8  &&
                     Honeycomb1.transform.position.z           >= 1.5  && Honeycomb1.transform.position.z           <= 2.3  &&
                     Honeycomb1.transform.eulerAngles.y        >= 45   && Honeycomb1.transform.eulerAngles.y        <= 55    )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Honeycomb2.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y             >= 77   && Model.transform.eulerAngles.y             <= 87   &&
                     UpperHoneycomb1.transform.localPosition.y >= 18   && UpperHoneycomb1.transform.localPosition.y <= 21   &&
                     HeadHoneycomb1.transform.eulerAngles.z    >= 60   && HeadHoneycomb1.transform.eulerAngles.z    <= 80   &&
                     Honeycomb1.transform.position.x           >= 3    && Honeycomb1.transform.position.x           <= 3.8  &&
                     Honeycomb1.transform.position.z           >= -2.3 && Honeycomb1.transform.position.z           <= -1.5 &&
                     Honeycomb1.transform.eulerAngles.y        >= 305  && Honeycomb1.transform.eulerAngles.y        <= 315   )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Honeycomb1.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y             >= 93   && Model.transform.eulerAngles.y             <= 103  &&
                     UpperHoneycomb2.transform.localPosition.y >= 18   && UpperHoneycomb2.transform.localPosition.y <= 21   &&
                     HeadHoneycomb2.transform.eulerAngles.z    >= 60   && HeadHoneycomb2.transform.eulerAngles.z    <= 80   &&
                     Honeycomb2.transform.position.x           >= 3    && Honeycomb2.transform.position.x           <= 3.8  &&
                     Honeycomb2.transform.position.z           >= 1.5  && Honeycomb2.transform.position.z           <= 2.3  &&
                     Honeycomb2.transform.eulerAngles.y        >= 45   && Honeycomb2.transform.eulerAngles.y        <= 55    )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Honeycomb1.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y             >= 77   && Model.transform.eulerAngles.y             <= 87   &&
                     UpperHoneycomb2.transform.localPosition.y >= 18   && UpperHoneycomb2.transform.localPosition.y <= 21   &&
                     HeadHoneycomb2.transform.eulerAngles.z    >= 60   && HeadHoneycomb2.transform.eulerAngles.z    <= 80   &&
                     Honeycomb2.transform.position.x           >= 3    && Honeycomb2.transform.position.x           <= 3.8  &&
                     Honeycomb2.transform.position.z           >= -2.3 && Honeycomb2.transform.position.z           <= -1.5 &&
                     Honeycomb2.transform.eulerAngles.y        >= 305  && Honeycomb2.transform.eulerAngles.y        <= 315   )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else
            {
                TestIndicatorX.SetActive(true);
                TestIndicatorV.SetActive(false);
            }
            //=================================================================================================
            //=================================================================================================
            //=================================================================================================
        }
        else
        {
            TestIndicatorX.SetActive(true);
            TestIndicatorV.SetActive(false);
        }
    }
}
