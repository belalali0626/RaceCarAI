using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackCheckpoints : MonoBehaviour
{
    public Text UIText;
    private List<CheckpointSingle> checkpointSingleList;
    public int nextCheckpointSingleIndex;

    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("cp");
        checkpointSingleList = new List<CheckpointSingle>();
        foreach(Transform checkpointSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();
            checkpointSingle.SetTrackCheckpoints(this);

            checkpointSingleList.Add(checkpointSingle); 
        }
    }

    public void PlayerThroughCheckpoint (CheckpointSingle checkpointSingle)
    {
        if(checkpointSingleList.IndexOf(checkpointSingle) == nextCheckpointSingleIndex)
        {
            nextCheckpointSingleIndex++;
            UIText.text = nextCheckpointSingleIndex + " / " + "10";
        }
    }
}
