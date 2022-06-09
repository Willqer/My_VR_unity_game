using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLwBL : MonoBehaviour
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
    [SerializeField] private GameObject UpperHardlight1;
    [SerializeField] private GameObject UpperHardlight2;
    [SerializeField] private GameObject HeadHardlight1;
    [SerializeField] private GameObject HeadHardlight2;

    [SerializeField] private GameObject TestIndicatorX;
    [SerializeField] private GameObject TestIndicatorV;

    void Update()
    {
        if (Honeycomb1.transform.position.x <= -6 && Honeycomb2.transform.position.x <= -6 &&
            Snoot1.transform.position.x     <= -6 && Snoot2.transform.position.x     <= -6 &&
            Model.transform.eulerAngles.y   >= 85 && Model.transform.eulerAngles.y   <= 95  )
        {
            //=================================================================================================
            //=================================================================================================
            //=================================================================================================
            if      (Softbox2.transform.position.x             <= -6    &&
                     UpperSoftbox1.transform.localPosition.y   >= 18    && UpperSoftbox1.transform.localPosition.y   <= 21  &&
                     HeadSoftbox1.transform.eulerAngles.z      >= 60    && HeadSoftbox1.transform.eulerAngles.z      <= 80  &&
                     Softbox1.transform.position.x             >= 2.2   && Softbox1.transform.position.x             <= 3.3 &&
                     Softbox1.transform.position.z             >= 1.5   && Softbox1.transform.position.z             <= 3.4 &&
                     Softbox1.transform.eulerAngles.y          >= 25    && Softbox1.transform.eulerAngles.y          <= 45   )
            {
                if      (Hardlight2.transform.position.x             <= -6    &&
                         UpperHardlight1.transform.localPosition.y   >= -6    && UpperHardlight1.transform.localPosition.y   <= 13  &&
                         HeadHardlight1.transform.eulerAngles.z      >= 85    && HeadHardlight1.transform.eulerAngles.z      <= 95  &&
                         Hardlight1.transform.position.x             >= 7.7   && Hardlight1.transform.position.x             <= 8.7 &&
                         Hardlight1.transform.position.z             >= -0.3  && Hardlight1.transform.position.z             <= 0.3 &&
                        (Hardlight1.transform.eulerAngles.y          >= 355   || Hardlight1.transform.eulerAngles.y          <= 5   ))
                {
                    TestIndicatorX.SetActive(false);
                    TestIndicatorV.SetActive(true);
                }
                else if (Hardlight1.transform.position.x             <= -6    &&
                         UpperHardlight2.transform.localPosition.y   >= -6    && UpperHardlight2.transform.localPosition.y   <= 13  &&
                         HeadHardlight2.transform.eulerAngles.z      >= 85    && HeadHardlight2.transform.eulerAngles.z      <= 95  &&
                         Hardlight2.transform.position.x             >= 7.7   && Hardlight2.transform.position.x             <= 8.7 &&
                         Hardlight2.transform.position.z             >= -0.3  && Hardlight2.transform.position.z             <= 0.3 &&
                         (Hardlight2.transform.eulerAngles.y         >= 355   || Hardlight2.transform.eulerAngles.y          <= 5   ))
                {
                    TestIndicatorX.SetActive(false);
                    TestIndicatorV.SetActive(true);
                }
                else
                {
                    TestIndicatorX.SetActive(true);
                    TestIndicatorV.SetActive(false);
                }
            }
            //=================================================================================================
            else if (Softbox2.transform.position.x             <= -6    &&
                     UpperSoftbox1.transform.localPosition.y   >= 18    && UpperSoftbox1.transform.localPosition.y   <= 21   &&
                     HeadSoftbox1.transform.eulerAngles.z      >= 60    && HeadSoftbox1.transform.eulerAngles.z      <= 80   &&
                     Softbox1.transform.position.x             >= 2.2   && Softbox1.transform.position.x             <= 3.3  &&
                     Softbox1.transform.position.z             >= -3.4  && Softbox1.transform.position.z             <= -1.5 &&
                     Softbox1.transform.eulerAngles.y          >= 320   && Softbox1.transform.eulerAngles.y          <= 330   )
            {
                if      (Hardlight2.transform.position.x             <= -6    &&
                         UpperHardlight1.transform.localPosition.y   >= -6    && UpperHardlight1.transform.localPosition.y   <= 13  &&
                         HeadHardlight1.transform.eulerAngles.z      >= 85    && HeadHardlight1.transform.eulerAngles.z      <= 95  &&
                         Hardlight1.transform.position.x             >= 7.7   && Hardlight1.transform.position.x             <= 8.7 &&
                         Hardlight1.transform.position.z             >= -0.3  && Hardlight1.transform.position.z             <= 0.3 &&
                        (Hardlight1.transform.eulerAngles.y          >= 355   || Hardlight1.transform.eulerAngles.y          <= 5   ))
                {
                    TestIndicatorX.SetActive(false);
                    TestIndicatorV.SetActive(true);
                }
                else if (Hardlight1.transform.position.x             <= -6    &&
                         UpperHardlight2.transform.localPosition.y   >= -6    && UpperHardlight2.transform.localPosition.y   <= 13  &&
                         HeadHardlight2.transform.eulerAngles.z      >= 85    && HeadHardlight2.transform.eulerAngles.z      <= 95  &&
                         Hardlight2.transform.position.x             >= 7.7   && Hardlight2.transform.position.x             <= 8.7 &&
                         Hardlight2.transform.position.z             >= -0.3  && Hardlight2.transform.position.z             <= 0.3 &&
                        (Hardlight2.transform.eulerAngles.y          >= 355   || Hardlight2.transform.eulerAngles.y          <= 5   ))
                {
                    TestIndicatorX.SetActive(false);
                    TestIndicatorV.SetActive(true);
                }
                else
                {
                    TestIndicatorX.SetActive(true);
                    TestIndicatorV.SetActive(false);
                }
            }
            //=================================================================================================
            else if (Softbox1.transform.position.x             <= -6    &&
                     UpperSoftbox2.transform.localPosition.y   >= 18    && UpperSoftbox2.transform.localPosition.y   <= 21  &&
                     HeadSoftbox2.transform.eulerAngles.z      >= 60    && HeadSoftbox2.transform.eulerAngles.z      <= 80  &&
                     Softbox2.transform.position.x             >= 2.2   && Softbox2.transform.position.x             <= 3.3 &&
                     Softbox2.transform.position.z             >= 1.5   && Softbox2.transform.position.z             <= 3.4 &&
                     Softbox2.transform.eulerAngles.y          >= 25    && Softbox2.transform.eulerAngles.y          <= 45   )
            {
                if (Hardlight2.transform.position.x                  <= -6    &&
                         UpperHardlight1.transform.localPosition.y   >= -6    && UpperHardlight1.transform.localPosition.y   <= 13  &&
                         HeadHardlight1.transform.eulerAngles.z      >= 85    && HeadHardlight1.transform.eulerAngles.z      <= 95  &&
                         Hardlight1.transform.position.x             >= 7.7   && Hardlight1.transform.position.x             <= 8.7 &&
                         Hardlight1.transform.position.z             >= -0.3  && Hardlight1.transform.position.z             <= 0.3 &&
                        (Hardlight1.transform.eulerAngles.y          >= 355   || Hardlight1.transform.eulerAngles.y          <= 5   ))
                {
                    TestIndicatorX.SetActive(false);
                    TestIndicatorV.SetActive(true);
                }
                else if (Hardlight1.transform.position.x             <= -6    &&
                         UpperHardlight2.transform.localPosition.y   >= -6    && UpperHardlight2.transform.localPosition.y   <= 13  &&
                         HeadHardlight2.transform.eulerAngles.z      >= 85    && HeadHardlight2.transform.eulerAngles.z      <= 95  &&
                         Hardlight2.transform.position.x             >= 7.7   && Hardlight2.transform.position.x             <= 8.7 &&
                         Hardlight2.transform.position.z             >= -0.3  && Hardlight2.transform.position.z             <= 0.3 &&
                        (Hardlight2.transform.eulerAngles.y          >= 355   || Hardlight2.transform.eulerAngles.y          <= 5   ))
                {
                    TestIndicatorX.SetActive(false);
                    TestIndicatorV.SetActive(true);
                }
                else
                {
                    TestIndicatorX.SetActive(true);
                    TestIndicatorV.SetActive(false);
                }
            }
            //=================================================================================================
            else if (Softbox1.transform.position.x             <= -6    &&
                     UpperSoftbox2.transform.localPosition.y   >= 18    && UpperSoftbox2.transform.localPosition.y   <= 21   &&
                     HeadSoftbox2.transform.eulerAngles.z      >= 60    && HeadSoftbox2.transform.eulerAngles.z      <= 80   &&
                     Softbox2.transform.position.x             >= 2.2   && Softbox2.transform.position.x             <= 3.3  &&
                     Softbox2.transform.position.z             >= -3.4  && Softbox2.transform.position.z             <= -1.5 &&
                     Softbox2.transform.eulerAngles.y          >= 320   && Softbox2.transform.eulerAngles.y          <= 330   )
            {
                if      (Hardlight2.transform.position.x             <= -6    &&
                         UpperHardlight1.transform.localPosition.y   >= -6    && UpperHardlight1.transform.localPosition.y   <= 13  &&
                         HeadHardlight1.transform.eulerAngles.z      >= 85    && HeadHardlight1.transform.eulerAngles.z      <= 95  &&
                         Hardlight1.transform.position.x             >= 7.7   && Hardlight1.transform.position.x             <= 8.7 &&
                         Hardlight1.transform.position.z             >= -0.3  && Hardlight1.transform.position.z             <= 0.3 &&
                        (Hardlight1.transform.eulerAngles.y          >= 355   || Hardlight1.transform.eulerAngles.y          <= 5   ))
                {
                    TestIndicatorX.SetActive(false);
                    TestIndicatorV.SetActive(true);
                }
                else if (Hardlight1.transform.position.x             <= -6    &&
                         UpperHardlight2.transform.localPosition.y   >= -6    && UpperHardlight2.transform.localPosition.y   <= 13  &&
                         HeadHardlight2.transform.eulerAngles.z      >= 85    && HeadHardlight2.transform.eulerAngles.z      <= 95  &&
                         Hardlight2.transform.position.x             >= 7.7   && Hardlight2.transform.position.x             <= 8.7 &&
                         Hardlight2.transform.position.z             >= -0.3  && Hardlight2.transform.position.z             <= 0.3 &&
                        (Hardlight2.transform.eulerAngles.y          >= 355   || Hardlight2.transform.eulerAngles.y          <= 5   ))
                {
                    TestIndicatorX.SetActive(false);
                    TestIndicatorV.SetActive(true);
                }
                else
                {
                    TestIndicatorX.SetActive(true);
                    TestIndicatorV.SetActive(false);
                }
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
