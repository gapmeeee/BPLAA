using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointSystem : MonoBehaviour
{

    public GameOverScreen gameOverScreen;
    
    public GhostController ghostController;
    public ArrayCoordinates coordinates;

    public const int NumOfCheckpoint = 10;
    [SerializeField] public CheckPoint[] ArrayPrefabs;
    internal int CurrentCheckPoint;

    public GameObject BPLA;
    public List<Transform> path;
    
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
        gameOverScreen.Restart();        
        SceneManager.LoadScene("Hangar");
        Application.Quit();
    }

}
