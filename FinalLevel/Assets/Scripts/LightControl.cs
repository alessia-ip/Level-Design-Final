using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public GameObject cyanEnd;
    public GameObject redEnd;
    public GameObject orangeEnd;
    public GameObject greenEnd;
    public GameObject blueEnd;
    public GameObject whiteEnd;
    public GameObject pinkEnd;
    public GameObject lightpinkEnd;
    
    public GameObject cyanEndLight;
    public GameObject redEndLight;
    public GameObject orangeEndLight;
    public GameObject greenEndLight;
    public GameObject blueEndLight;
    public GameObject whiteEndLight;
    public GameObject pinkEndLight;
    public GameObject lightpinkEndLight;

    private void Start()
    {
        cyanEndLight.SetActive(false);
        redEndLight.SetActive(false);
        orangeEndLight.SetActive(false);
        greenEndLight.SetActive(false);
        blueEndLight.SetActive(false);
        whiteEndLight.SetActive(false);
        pinkEndLight.SetActive(false);
        lightpinkEndLight.SetActive(false);
    }

    private void Update()
    {
        if (cyanEnd.activeSelf == true && redEnd.activeSelf == true && orangeEnd.activeSelf == true &&
            greenEnd.activeSelf == true
            && blueEnd.activeSelf == true && whiteEnd.activeSelf == true && pinkEnd.activeSelf == true &&
            lightpinkEnd.activeSelf == true)
        {
            cyanEndLight.SetActive(true);
            redEndLight.SetActive(true);
            orangeEndLight.SetActive(true);
            greenEndLight.SetActive(true);
            blueEndLight.SetActive(true);
            whiteEndLight.SetActive(true);
            pinkEndLight.SetActive(true);
            lightpinkEndLight.SetActive(true);
        }
    }
}
