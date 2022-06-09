using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightValueMini : MonoBehaviour
{
    [SerializeField] private float intensityVal = 0.2f;
    [SerializeField] private Light light1;
    [SerializeField] private Light light2;
    [SerializeField] private Light light3;
    [SerializeField] private Light light4;

    void Start()
    {
        light1.intensity = intensityVal;
        light2.intensity = intensityVal;
        light3.intensity = intensityVal;
        light4.intensity = intensityVal;
    }

    void Update()
    {}
}
