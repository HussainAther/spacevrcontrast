using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    //public Transform xrOriginTransform;

    //public GameObject xrRig
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           other.gameObject.transform.position = new Vector3(-42.17f, -52.64f, 5.59f);
        }
    }

    //public void MoveOutside()
    //{
    //    xrOriginTransform.position = new Vector3(-42.17f, -52.64f, 5.59f);
    //}
}
