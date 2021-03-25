using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HELP : MonoBehaviour
{

    public GameObject HELPTEXT;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HELPTEXT.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HELPTEXT.SetActive(false);
        }
    }
}
