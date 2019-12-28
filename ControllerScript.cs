using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject go;
    void Start()
    {
        go = new GameObject();
    }

    void Update()
    {
        RaycastHit hit;
        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider != null)
            {
                if (go != hit.collider.gameObject)
                {
                    go.transform.SendMessage("OnVRExit");
                    go = hit.transform.gameObject;
                    go.transform.SendMessage("OnVREnter");
                }
                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    go.transform.SendMessage("OVRTriggerDown");
                }
                /*
                if(OVRInput.GetDown(OVRInput.Button.One))
                {

                }

                if (OVRInput.GetDown(OVRInput.Button.Two))
                {

                }
                */
            }
        }
        else
        {
            if (go != null)
            {
                go.transform.SendMessage("OnVRExit");
                go = new GameObject();
            }
        }
    }
}
