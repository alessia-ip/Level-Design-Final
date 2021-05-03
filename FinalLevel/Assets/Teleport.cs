using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
  public GameObject exitPortal;
  public GameObject enterPortal;
  public CharacterController player;

  private void OnTriggerEnter(Collider other)
  {
   
    if (other.gameObject.tag.Contains("Portal"))
    {
      Debug.Log("Yay");
      player.enabled = false;
      transform.position = exitPortal.transform.position;
      Destroy(exitPortal);
      Destroy(enterPortal);
      player.enabled = true;
    }
  }
}
