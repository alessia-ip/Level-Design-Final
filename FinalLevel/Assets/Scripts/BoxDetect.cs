using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDetect : MonoBehaviour
{
    public GameObject box;
    // Start is called before the first frame update

    public GameObject breakKey;
    private bool breakable;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (breakable == true && Input.GetKeyDown(KeyCode.E))
        {
            breakKey.SetActive(false);
            Destroy(box);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Detect"){
            //Destroy(box);
            breakable = true;
            breakKey.SetActive(true);
        }
        else
        {
            breakable = false;
            breakKey.SetActive(true);
        }
      
            
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Detect"){
            //Destroy(box);
            breakable = false;
            breakKey.SetActive(false);
        }
        else
        {
            breakKey.SetActive(false);
        }    
       
    }

}
