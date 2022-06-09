using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSS : MonoBehaviour
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

    [SerializeField] private GameObject UpperSoftbox1;
    [SerializeField] private GameObject UpperSoftbox2;
    [SerializeField] private GameObject HeadSoftbox1;
    [SerializeField] private GameObject HeadSoftbox2;

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

        UpperSoftbox1 = GameObject.Find("Softbox1/UpperTripod");
        UpperSoftbox2 = GameObject.Find("Softbox2/UpperTripod");
        HeadSoftbox1 = GameObject.Find("Softbox1/UpperTripod/Head");
        HeadSoftbox2 = GameObject.Find("Softbox2/UpperTripod/Head");
        */
    }
    void Update()
    {
        if (Hardlight1.transform.position.x <= -6 && Hardlight2.transform.position.x <= -6 &&
            Honeycomb1.transform.position.x <= -6 && Honeycomb2.transform.position.x <= -6 &&
            Snoot1.transform.position.x     <= -6 && Snoot2.transform.position.x     <= -6  )
        {
            //=================================================================================================
            //=================================================================================================
            //=================================================================================================
            if      (Softbox2.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y           >= 120  && Model.transform.eulerAngles.y           <= 130 &&
                     UpperSoftbox1.transform.localPosition.y >= -2   && UpperSoftbox1.transform.localPosition.y <= 2   &&
                     HeadSoftbox1.transform.eulerAngles.z    >= 85   && HeadSoftbox1.transform.eulerAngles.z    <= 95  &&
                     Softbox1.transform.position.x           >= 6    && Softbox1.transform.position.x           <= 7.2 &&
                     Softbox1.transform.position.z           >= 2.6  && Softbox1.transform.position.z           <= 5   &&
                     Softbox1.transform.eulerAngles.y        >= 85   && Softbox1.transform.eulerAngles.y        <= 95   )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox2.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y           >= 50   && Model.transform.eulerAngles.y           <= 60  &&
                     UpperSoftbox1.transform.localPosition.y >= -2   && UpperSoftbox1.transform.localPosition.y <= 2   &&
                     HeadSoftbox1.transform.eulerAngles.z    >= 85   && HeadSoftbox1.transform.eulerAngles.z    <= 95  &&
                     Softbox1.transform.position.x           >= 6    && Softbox1.transform.position.x           <= 7.2 &&
                     Softbox1.transform.position.z           >= -2.6 && Softbox1.transform.position.z           <= -5  &&
                     Softbox1.transform.eulerAngles.y        >= 265  && Softbox1.transform.eulerAngles.y        <= 275  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox1.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y           >= 120  && Model.transform.eulerAngles.y           <= 130 &&
                     UpperSoftbox2.transform.localPosition.y >= -2   && UpperSoftbox2.transform.localPosition.y <= 2   &&
                     HeadSoftbox2.transform.eulerAngles.z    >= 85   && HeadSoftbox2.transform.eulerAngles.z    <= 95  &&
                     Softbox2.transform.position.x           >= 6    && Softbox2.transform.position.x           <= 7.2 &&
                     Softbox2.transform.position.z           >= 2.6  && Softbox2.transform.position.z           <= 5   &&
                     Softbox2.transform.eulerAngles.y        >= 85   && Softbox2.transform.eulerAngles.y       <= 95   )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox1.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y           >= 50   && Model.transform.eulerAngles.y           <= 60  &&
                     UpperSoftbox2.transform.localPosition.y >= -2   && UpperSoftbox2.transform.localPosition.y <= 2   &&
                     HeadSoftbox2.transform.eulerAngles.z    >= 85   && HeadSoftbox2.transform.eulerAngles.z    <= 95  &&
                     Softbox2.transform.position.x           >= 6    && Softbox2.transform.position.x           <= 7.2 &&
                     Softbox2.transform.position.z           >= -2.6 && Softbox2.transform.position.z           <= -5  &&
                     Softbox2.transform.eulerAngles.y        >= 265  && Softbox2.transform.eulerAngles.y        <= 275  )
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