using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grappleOff : MonoBehaviour
{
    public GameObject grappleOffHook;
    public GameObject grappleOffFish;
    public GameObject grappleOffModel;
    public GameObject grappleOffGun;

    private void Start()
    {
        grappleOffFish.SetActive(false);
        grappleOffHook.SetActive(false);
        grappleOffGun.SetActive(false);
        grappleOffModel.SetActive(false);
    }
}
