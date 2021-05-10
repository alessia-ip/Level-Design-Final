using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScript : MonoBehaviour
{
    public GameManager manager;
    public GameObject endPos;
    
    

    private void Update()
    {
        if (manager.GetComponent<LightControl>().end == true)
        {
            Debug.Log("move me");
            Vector3 pos = transform.localPosition;
            Vector3 whoopie = Vector3.MoveTowards(pos,Vector3.zero, 1f);
            Quaternion rotate = transform.localRotation;
            Quaternion idontwanttolive = Quaternion.RotateTowards(rotate, Quaternion.identity, 10);
            transform.localPosition = whoopie;
            transform.localRotation = idontwanttolive;
           
        }

        if (transform.position == endPos.transform.position && transform.rotation == endPos.transform.rotation)
        {
            transform.SetParent(null);
            GetComponent<Animator>().enabled = true;
        }
    }
}
