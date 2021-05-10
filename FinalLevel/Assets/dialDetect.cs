using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialDetect : MonoBehaviour
{
    public GameObject box;
    // Start is called before the first frame update

    public GameObject breakKey;
    private bool breakable;
    public GameManager manager;
    
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

        if (other.gameObject.tag == "Dial")
        {
            if(manager.instance.heldrock == true)
            {
                Debug.Log("here");
                //Destroy(box);
                breakable = false;
                breakKey.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
       
        if(other.gameObject.tag == "Dial"){
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
