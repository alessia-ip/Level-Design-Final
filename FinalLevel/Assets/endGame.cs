using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public GameObject original;
    public GameObject end;
    private bool onTheDial;

    private void Start()
    {
        
        onTheDial = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("SunDial180"))
        {
            onTheDial = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("SunDial180"))
        {
            onTheDial = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("EEEEEEEEEEEEEEEE");
        }
        if (Input.GetKeyDown(KeyCode.E) && original.activeInHierarchy == false && onTheDial == true)
        {
            Debug.Log("BAM");
            end.SetActive(true);
        }
    }
}
