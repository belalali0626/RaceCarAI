using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointSingle : MonoBehaviour
{
    private TrackCheckpoints trackCheckpoints;
    private void OnTriggerEnter(Collider other)
    {
        trackCheckpoints.PlayerThroughCheckpoint(this);
      
    }

    public void SetTrackCheckpoints(TrackCheckpoints trackCheckpoints)
    {
        this.trackCheckpoints = trackCheckpoints;
    }
}
