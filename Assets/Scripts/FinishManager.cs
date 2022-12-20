using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishManager : MonoBehaviour
{
    public TrackCheckpoints tcs;
    public int index;

    private void Awake()
    {
        tcs = GameObject.FindGameObjectWithTag("tcs").GetComponent<TrackCheckpoints>();
    }

    private void OnTriggerEnter(Collider other)
    {
        index = tcs.nextCheckpointSingleIndex;

        if (index >= 10)
        {
            GameObject.Find("Car").SendMessage("finish");
        }
        else
        {
            Debug.Log("Wrong");
        }
    }
}
