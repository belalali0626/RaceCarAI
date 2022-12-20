using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public GameObject finish;
    public GameObject start;
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Car").SendMessage("startRace");
        StartCoroutine(countdown());
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(3);
        Instantiate(finish);
        Debug.Log("FINISH SPAWNED");
        Destroy(start);


    }
}
