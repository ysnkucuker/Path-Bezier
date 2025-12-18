using PathCreation.Examples;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarCollider : MonoBehaviour
{
    public GameObject levelFailedPanel;
    public GameObject levelPassedPanel;
    public PathFollower myPathFollower;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstecle")
        {
            myPathFollower.isMove = false;
            myPathFollower.isFinished = true;
            levelFailedPanel.SetActive(true);
            Debug.Log("CRUSHED");
        }
        if(other.gameObject.tag == "FinishPoint")
        {
            myPathFollower.isFinished = false;
            levelPassedPanel.SetActive(true);
            Debug.Log("Level Complete");
        }
    }
}
