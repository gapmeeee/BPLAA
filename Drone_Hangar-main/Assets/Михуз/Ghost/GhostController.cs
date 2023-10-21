using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
    public static List<Transform> _coordsBPLA;
    public GameObject arrayCoordinates;  

    public void Start_GhostController()
    {
        gameObject.SetActive(true);
        for (int i = 0; i < 10; i++) Debug.Log("Aye");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
