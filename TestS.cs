using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestS : MonoBehaviour
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

    [SerializeField] private GameObject UpperHardLight1;
    [SerializeField] private GameObject UpperHardLight2;
    [SerializeField] private GameObject HeadHardLight1;
    [SerializeField] private GameObject HeadHardLight2;

    [SerializeField] private GameObject UpperHoneycomb1;
    [SerializeField] private GameObject UpperHoneycomb2;
    [SerializeField] private GameObject HeadHoneycomb1;
    [SerializeField] private GameObject HeadHoneycomb2;

    [SerializeField] private GameObject UpperSnoot1;
    [SerializeField] private GameObject UpperSnoot2;
    [SerializeField] private GameObject HeadSnoot1;
    [SerializeField] private GameObject HeadSnoot2;

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
        UpperHardLight1 = GameObject.Find("HrdLght1/UpperTripod");
        UpperHardLight2 = GameObject.Find("HrdLght2/UpperTripod");
        HeadHardLight1 = GameObject.Find("HrdLght1/UpperTripod/Head");
        HeadHardLight2 = GameObject.Find("HrdLght2/UpperTripod/Head");
        UpperHoneycomb1 = GameObject.Find("HnyCmb1/UpperTripod");
        UpperHoneycomb2 = GameObject.Find("HnyCmb2/UpperTripod");
        HeadHoneycomb1 = GameObject.Find("HnyCmb1/UpperTripod/Head");
        HeadHoneycomb2 = GameObject.Find("HnyCmb2/UpperTripod/Head");
        UpperSnoot1 = GameObject.Find("Snoot1/UpperTripod");
        UpperSnoot2 = GameObject.Find("Snoot2/UpperTripod");
        HeadSnoot1 = GameObject.Find("Snoot1/UpperTripod/Head");
        HeadSnoot2 = GameObject.Find("Snoot2/UpperTripod/Head");
        */
    }
    void Update()
    {
        if (Hardlight1.transform.position.x <= -6 && Hardlight2.transform.position.x <= -6 &&
            Honeycomb1.transform.position.x <= -6 && Honeycomb2.transform.position.x <= -6 &&
            Snoot1.transform.position.x     <= -6 && Snoot2.transform.position.x     <= -6 &&
            Model.transform.eulerAngles.y   >= 85 && Model.transform.eulerAngles.y   <= 95  )
        {
            //=================================================================================================
            //=================================================================================================
            //=================================================================================================
            if      (Softbox2.transform.position.x           <= -6  &&
                     UpperSoftbox1.transform.localPosition.y >= -2  && UpperSoftbox1.transform.localPosition.y <= 2  &&
                     HeadSoftbox1.transform.eulerAngles.z    >= 85  && HeadSoftbox1.transform.eulerAngles.z    <= 95 &&
                     Softbox1.transform.position.x           >= 4.5 && Softbox1.transform.position.x           <= 5  &&
                     Softbox1.transform.position.z           >= 2   &&
                     Softbox1.transform.eulerAngles.y        >= 85  && Softbox1.transform.eulerAngles.y        <= 95  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox2.transform.position.x           <= -6  &&
                     UpperSoftbox1.transform.localPosition.y >= -2  && UpperSoftbox1.transform.localPosition.y <= 2  &&
                     HeadSoftbox1.transform.eulerAngles.z    >= 85  && HeadSoftbox1.transform.eulerAngles.z    <= 95 &&
                     Softbox1.transform.position.x           >= 4.5 && Softbox1.transform.position.x           <= 5  &&
                     Softbox1.transform.position.z           <= -2  &&
                     Softbox1.transform.eulerAngles.y        >= 265 && Softbox1.transform.eulerAngles.y        <= 275 )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox1.transform.position.x           <= -6  &&
                     UpperSoftbox2.transform.localPosition.y >= -2  && UpperSoftbox2.transform.localPosition.y <= 2  &&
                     HeadSoftbox2.transform.eulerAngles.z    >= 85  && HeadSoftbox2.transform.eulerAngles.z    <= 95 &&
                     Softbox2.transform.position.x           >= 4.5 && Softbox2.transform.position.x           <= 5  &&
                     Softbox2.transform.position.z           >= 2   &&
                     Softbox2.transform.eulerAngles.y        >= 85  && Softbox2.transform.eulerAngles.y        <= 95  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox1.transform.position.x           <= -6  &&
                     UpperSoftbox2.transform.localPosition.y >= -2  && UpperSoftbox2.transform.localPosition.y <= 2  &&
                     HeadSoftbox2.transform.eulerAngles.z    >= 85  && HeadSoftbox2.transform.eulerAngles.z    <= 95 &&
                     Softbox2.transform.position.x           >= 4.5 && Softbox2.transform.position.x           <= 5  &&
                     Softbox2.transform.position.z           <= -2  &&
                     Softbox2.transform.eulerAngles.y        >= 265 && Softbox2.transform.eulerAngles.y        <= 275 )
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
        //=================================================================================================
        else if (Softbox1.transform.position.x   <= -6 && Softbox2.transform.position.x   <= -6 &&
                 Honeycomb1.transform.position.x <= -6 && Honeycomb2.transform.position.x <= -6 &&
                 Snoot1.transform.position.x     <= -6 && Snoot2.transform.position.x     <= -6 &&
                 Model.transform.eulerAngles.y   >= 85 && Model.transform.eulerAngles.y   <= 95  )
        {
            //=================================================================================================
            //=================================================================================================
            //=================================================================================================
            if      (Hardlight2.transform.position.x           <= -6  &&
                     UpperHardLight1.transform.localPosition.y >= -2  && UpperHardLight1.transform.localPosition.y <= 2  &&
                     HeadHardLight1.transform.eulerAngles.z    >= 85  && HeadHardLight1.transform.eulerAngles.z    <= 95 &&
                     Hardlight1.transform.position.x           >= 4.5 && Hardlight1.transform.position.x           <= 5  &&
                     Hardlight1.transform.position.z           >= 2   &&
                     Hardlight1.transform.eulerAngles.y        >= 85  && Hardlight1.transform.eulerAngles.y        <= 95  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Hardlight2.transform.position.x           <= -6  &&
                     UpperHardLight1.transform.localPosition.y >= -2  && UpperHardLight1.transform.localPosition.y <= 2  &&
                     HeadHardLight1.transform.eulerAngles.z    >= 85  && HeadHardLight1.transform.eulerAngles.z    <= 95 &&
                     Hardlight1.transform.position.x           >= 4.5 && Hardlight1.transform.position.x           <= 5  &&
                     Hardlight1.transform.position.z           <= -2  &&
                     Hardlight1.transform.eulerAngles.y        >= 265 && Hardlight1.transform.eulerAngles.y        <= 275 )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Hardlight1.transform.position.x           <= -6  &&
                     UpperHardLight2.transform.localPosition.y >= -2  && UpperHardLight2.transform.localPosition.y <= 2  &&
                     HeadHardLight2.transform.eulerAngles.z    >= 85  && HeadHardLight2.transform.eulerAngles.z    <= 95 &&
                     Hardlight2.transform.position.x           >= 4.5 && Hardlight2.transform.position.x           <= 5  &&
                     Hardlight2.transform.position.z           >= 2   &&
                     Hardlight2.transform.eulerAngles.y        >= 85  && Hardlight2.transform.eulerAngles.y        <= 95  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Hardlight1.transform.position.x           <= -6  &&
                     UpperHardLight2.transform.localPosition.y >= -2  && UpperHardLight2.transform.localPosition.y <= 2  &&
                     HeadHardLight2.transform.eulerAngles.z    >= 85  && HeadHardLight2.transform.eulerAngles.z    <= 95 &&
                     Hardlight2.transform.position.x           >= 4.5 && Hardlight2.transform.position.x           <= 5  &&
                     Hardlight2.transform.position.z           <= -2  &&
                     Hardlight2.transform.eulerAngles.y        >= 265 && Hardlight2.transform.eulerAngles.y        <= 275 )
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
        //=================================================================================================
        else if (Softbox1.transform.position.x   <= -6 && Softbox2.transform.position.x   <= -6 &&
                 Hardlight1.transform.position.x <= -6 && Hardlight2.transform.position.x <= -6 &&
                 Snoot1.transform.position.x     <= -6 && Snoot2.transform.position.x     <= -6 &&
                 Model.transform.eulerAngles.y   >= 85 && Model.transform.eulerAngles.y   <= 95  )
        {
            //=================================================================================================
            //=================================================================================================
            //=================================================================================================
            if      (Honeycomb2.transform.position.x           <= -6  &&
                     UpperHoneycomb1.transform.localPosition.y >= -2  && UpperHoneycomb1.transform.localPosition.y <= 2  &&
                     HeadHoneycomb1.transform.localPosition.y  >= 85  && HeadHoneycomb1.transform.localPosition.y  <= 95 &&
                     Honeycomb1.transform.position.x           >= 4.5 && Honeycomb1.transform.position.x           <= 5  &&
                     Honeycomb1.transform.position.z           >= 2   &&
                     Honeycomb1.transform.eulerAngles.y        >= 85  && Honeycomb1.transform.eulerAngles.y        <= 95  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Honeycomb2.transform.position.x           <= -6  &&
                     UpperHoneycomb1.transform.localPosition.y >= -2  && UpperHoneycomb1.transform.localPosition.y <= 2  &&
                     HeadHoneycomb1.transform.eulerAngles.z    >= 85  && HeadHoneycomb1.transform.eulerAngles.z    <= 95 &&
                     Honeycomb1.transform.position.x           >= 4.5 && Honeycomb1.transform.position.x           <= 5  &&
                     Honeycomb1.transform.position.z           <= -2  &&
                     Honeycomb1.transform.eulerAngles.y        >= 265 && Honeycomb1.transform.eulerAngles.y        <= 275 )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Honeycomb1.transform.position.x           <= -6  &&
                     UpperHoneycomb2.transform.localPosition.y >= -2  && UpperHoneycomb2.transform.localPosition.y <= 2  &&
                     HeadHoneycomb2.transform.eulerAngles.z    >= 85  && HeadHoneycomb2.transform.eulerAngles.z    <= 95 &&
                     Honeycomb2.transform.position.x           >= 4.5 && Honeycomb2.transform.position.x           <= 5  &&
                     Honeycomb2.transform.position.z           >= 2   &&
                     Honeycomb2.transform.eulerAngles.y        >= 85  && Honeycomb2.transform.eulerAngles.y        <= 95  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Honeycomb1.transform.position.x           <= -6  &&
                     UpperHoneycomb2.transform.localPosition.y >= -2  && UpperHoneycomb2.transform.localPosition.y <= 2  &&
                     HeadHoneycomb2.transform.eulerAngles.z    >= 85  && HeadHoneycomb2.transform.eulerAngles.z    <= 95 &&
                     Honeycomb2.transform.position.x           >= 4.5 && Honeycomb2.transform.position.x           <= 5  &&
                     Honeycomb2.transform.position.z           <= -2  &&
                     Honeycomb2.transform.eulerAngles.y        >= 265 && Honeycomb2.transform.eulerAngles.y        <= 275 )
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
        //=================================================================================================
        else if (Softbox1.transform.position.x    <= -6 && Softbox2.transform.position.x    <= -6 &&
                 Hardlight1.transform.position.x  <= -6 && Hardlight2.transform.position.x  <= -6 &&
                 Honeycomb1.transform.position.x  <= -6 && Honeycomb2.transform.position.x  <= -6 &&
                 Model.transform.eulerAngles.y    >= 85 && Model.transform.eulerAngles.y    <= 95  )
        {
            //=================================================================================================
            //=================================================================================================
            //=================================================================================================
            if      (Snoot2.transform.position.x           <= -6   &&
                     UpperSnoot1.transform.localPosition.y >= -2   && UpperSnoot1.transform.localPosition.y <= 2  &&
                     HeadSnoot1.transform.eulerAngles.z    >= 85   && HeadSnoot1.transform.eulerAngles.z    <= 95 &&
                     Snoot1.transform.position.x           >= 4.5  && Snoot1.transform.position.x           <= 5  &&
                     Snoot1.transform.position.z           >= 2.8  && 
                     Snoot1.transform.eulerAngles.y        >= 85   && Snoot1.transform.eulerAngles.y        <= 95  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Snoot2.transform.position.x           <= -6   &&
                     UpperSnoot1.transform.localPosition.y >= -2   && UpperSnoot1.transform.localPosition.y <= 2  &&
                     HeadSnoot1.transform.eulerAngles.z    >= 85   && HeadSnoot1.transform.eulerAngles.z    <= 95 &&
                     Snoot1.transform.position.x           >= 4.5  && Snoot1.transform.position.x           <= 5  &&
                     Snoot1.transform.position.z           <= -2.8 &&
                     Snoot1.transform.eulerAngles.y        >= 265  && Snoot1.transform.eulerAngles.y        <= 275 )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Snoot1.transform.position.x           <= -6   &&
                     UpperSnoot2.transform.localPosition.y >= -2   && UpperSnoot2.transform.localPosition.y <= 2  &&
                     HeadSnoot2.transform.eulerAngles.z    >= 85   && HeadSnoot2.transform.eulerAngles.z    <= 95 &&
                     Snoot2.transform.position.x           >= 4.5  && Snoot2.transform.position.x           <= 5  &&
                     Snoot2.transform.position.z           >= 2.8  &&
                     Snoot2.transform.eulerAngles.y        >= 85   && Snoot2.transform.eulerAngles.y        <= 95  )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Snoot1.transform.position.x           <= -6   &&
                     UpperSnoot2.transform.localPosition.y >= -2   && UpperSnoot2.transform.localPosition.y <= 2  &&
                     HeadSnoot2.transform.eulerAngles.z    >= 85   && HeadSnoot2.transform.eulerAngles.z    <= 95 &&
                     Snoot2.transform.position.x           >= 4.5  && Snoot2.transform.position.x           <= 5  &&
                     Snoot2.transform.position.z           <= -2.8 &&
                     Snoot2.transform.eulerAngles.y        >= 265  && Snoot2.transform.eulerAngles.y        <= 275 )
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
        //=================================================================================================
        else
        {
            TestIndicatorX.SetActive(true);
            TestIndicatorV.SetActive(false);
        }
    }
}