using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterscript : MonoBehaviour
{

    public GameObject water;
    private Vector3 newPos;
    private bool lowerWater = false;
    public float NEWY = -23.32296f;
    public float SPEED = 0.1f;
    
    private void Start()
    {
        newPos = new Vector3(water.transform.position.x, NEWY, water.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (lowerWater == true)
        {
            water.transform.position = Vector3.Lerp(
                water.transform.position, 
                newPos, 
                SPEED * Time.deltaTime );
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("lower the water");
            lowerWater = true;
        }
    }
}
