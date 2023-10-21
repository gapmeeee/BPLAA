using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Material SecondColor;
    internal bool EnterFlag = false;
    internal int Index;
    private CheckPointSystem checkPointSystem;

    private void Awake()
    {
        checkPointSystem = gameObject.GetComponentInParent<CheckPointSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Index == checkPointSystem.ArrayPrefabs.Length - 1)
        {
            checkPointSystem.GameOver();
        }
        if (other.name ==  "Drone_White" && EnterFlag)
        {
            gameObject.GetComponent<Renderer>().material = SecondColor;

            checkPointSystem.ArrayPrefabs[Index + 1].EnterFlag = true;
        }
    }
}
