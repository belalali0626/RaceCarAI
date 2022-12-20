using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class GameController : MonoBehaviour

    {

    public GameObject spawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            Debug.Log("COLLISION DETECTED");
            SceneManager.LoadScene("RaceZone1");

        }
    }


    }
