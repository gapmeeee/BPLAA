using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Restart()
    {
        gameObject.SetActive(true);

    }
    
    public void ResetGame()
    {
        SceneManager.LoadScene("Hangar");
    }
}
