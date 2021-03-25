using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoffhelp : MonoBehaviour
{
    private bool LMB = false;
    private bool RMB = false;
    private bool E = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            E = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            LMB = true;
        }

        if (Input.GetMouseButtonDown(1))
        {
            RMB = true;
        }

        if (LMB == true && RMB == true && E == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
