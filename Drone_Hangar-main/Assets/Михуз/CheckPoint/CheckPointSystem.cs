using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointSystem : MonoBehaviour
{

    public const int NumOfCheckpoint = 10;
    [SerializeField] public CheckPoint[] ArrayPrefabs;
    internal int CurrentCheckPoint;
    void Awake()
    {       
        if (gameObject.transform.childCount> 0)
        {
            ArrayPrefabs = gameObject.GetComponentsInChildren<CheckPoint>();
            ArrayPrefabs[0].EnterFlag = true;
            ArrayPrefabs[0].Index = 0;
            for (int i = 1; i < ArrayPrefabs.Length; i++)
            {
                ArrayPrefabs[i].EnterFlag = false;
                ArrayPrefabs[i].Index = i;
            }
        }


    }

    public void GameOver()
    {
        Debug.Log("ayeaye");
        Application.Quit();
    }
}
