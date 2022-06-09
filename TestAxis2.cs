using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAxis2 : MonoBehaviour
{
    [SerializeField] private GameObject CubeX;
    [SerializeField] private GameObject CubeY;
    [SerializeField] private GameObject Sphere;
    void Update()
    {
        float AxisX;
        float AxisY;
        AxisX = Input.GetAxis("axisX");
        AxisY = Input.GetAxis("axisY");

        if (AxisX == -1f || AxisX == 1f)
        {
            CubeX.SetActive(true);
        }
        else
        {
            CubeX.SetActive(false);
        }
        if (AxisY == -1f || AxisY == 1f)
        {
            CubeY.SetActive(true);
        }
        else
        {
            CubeY.SetActive(false);
        }

        if (AxisX == -1f)
        {
            Sphere.transform.position = new Vector3(3f, 2f, 1f);
        }
        else if (AxisX == 1f)
        {
            Sphere.transform.position = new Vector3(3f, 2f, -1f);
        }
        else if (AxisY == -1f)
        {
            Sphere.transform.position = new Vector3(3f, 3f, 0f);
        }
        else if (AxisY == 1f)
        {
            Sphere.transform.position = new Vector3(3f, 1f, 0f);
        }
        else
        {
            Sphere.transform.position = new Vector3(3f, 2f, 0f);
        }

    }
}
