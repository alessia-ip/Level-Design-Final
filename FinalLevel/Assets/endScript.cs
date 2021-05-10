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
            Vector3 pos = transform.position;
            Vector3 whoopie = Vector3.MoveTowards(pos,Vector3.zero, 1);
            Quaternion rotate = transform.rotation;
            Quaternion idontwanttolive = Quaternion.RotateTowards(rotate, endPos.transform.rotation,3);
            transform.position = whoopie;
            transform.rotation = idontwanttolive;
        }

        if (transform.position == endPos.transform.position && transform.rotation == endPos.transform.rotation)
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
