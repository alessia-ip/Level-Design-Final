using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    private GameManager manager;
    public bool isGrapple = false;

    public GameObject grappleHook;
    public GameObject grappleHookGun;
    public GameObject fishingHook;
    
    private void Start()
    {
        manager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Player")
        {
            if (!isGrapple)
            {
                manager.collectedCollectables++;
                manager.collectSFX();
            }
            else
            {
                grappleHook.SetActive(true);
                grappleHookGun.SetActive(true);
                fishingHook.SetActive(true);
            }
            this.gameObject.SetActive(false);
        }
    }
}
