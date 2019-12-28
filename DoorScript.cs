using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private bool opened;
    public Vector3 openPosition, closedPosition;
    void Start()
    {
        opened = false;
        closedPosition = transform.position;
    }

    void Update()
    {
        if (!opened)
        {
            transform.position = Vector3.Lerp(transform.position, closedPosition, Time.deltaTime * 5f);
        }

        if (opened)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition, Time.deltaTime * 5f);
        }

    }

    void OnVRTriggerDown()
    {
        opened = true;
    }
}
