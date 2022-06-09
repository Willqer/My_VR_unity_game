using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRB : MonoBehaviour
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
                     Model.transform.eulerAngles.y           >= 65   && Model.transform.eulerAngles.y           <= 75   &&
                     UpperSoftbox1.transform.localPosition.y >= 18   && UpperSoftbox1.transform.localPosition.y <= 21   &&
                     HeadSoftbox1.transform.eulerAngles.z    >= 60   && HeadSoftbox1.transform.eulerAngles.z    <= 80   &&
                     Softbox1.transform.position.x           >= 2.3  && Softbox1.transform.position.x           <= 3.0  &&
                     Softbox1.transform.position.z           >= 1.9  && Softbox1.transform.position.z           <= 2.5  &&
                     Softbox1.transform.eulerAngles.y        >= 50   && Softbox1.transform.eulerAngles.y        <= 60    )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox2.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y           >= 105  && Model.transform.eulerAngles.y           <= 115  &&
                     UpperSoftbox1.transform.localPosition.y >= 18   && UpperSoftbox1.transform.localPosition.y <= 21   &&
                     HeadSoftbox1.transform.eulerAngles.z    >= 60   && HeadSoftbox1.transform.eulerAngles.z    <= 80   &&
                     Softbox1.transform.position.x           >= 2.3  && Softbox1.transform.position.x           <= 3.0  &&
                     Softbox1.transform.position.z           >= -2.5 && Softbox1.transform.position.z           <= -1.9 &&
                     Softbox1.transform.eulerAngles.y        >= 300  && Softbox1.transform.eulerAngles.y        <= 310   )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox1.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y           >= 65   && Model.transform.eulerAngles.y           <= 75   &&
                     UpperSoftbox2.transform.localPosition.y >= 18   && UpperSoftbox2.transform.localPosition.y <= 21   &&
                     HeadSoftbox2.transform.eulerAngles.z    >= 60   && HeadSoftbox2.transform.eulerAngles.z    <= 80   &&
                     Softbox2.transform.position.x           >= 2.3  && Softbox2.transform.position.x           <= 3.0  &&
                     Softbox2.transform.position.z           >= 1.9  && Softbox2.transform.position.z           <= 2.5  &&
                     Softbox2.transform.eulerAngles.y        >= 50   && Softbox2.transform.eulerAngles.y        <= 60    )
            {
                TestIndicatorX.SetActive(false);
                TestIndicatorV.SetActive(true);
            }
            //=================================================================================================
            else if (Softbox1.transform.position.x           <= -6   &&
                     Model.transform.eulerAngles.y           >= 105  && Model.transform.eulerAngles.y           <= 115  &&
                     UpperSoftbox2.transform.localPosition.y >= 18   && UpperSoftbox2.transform.localPosition.y <= 21   &&
                     HeadSoftbox2.transform.eulerAngles.z    >= 60   && HeadSoftbox2.transform.eulerAngles.z    <= 80   &&
                     Softbox2.transform.position.x           >= 2.3  && Softbox2.transform.position.x           <= 3.0  &&
                     Softbox2.transform.position.z           >= -2.5 && Softbox2.transform.position.z           <= -1.9 &&
                     Softbox2.transform.eulerAngles.y        >= 300  && Softbox2.transform.eulerAngles.y        <= 310   )
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
