using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameOptionsAndRestartGameScript : MonoBehaviour
{
    public static PauseGameOptionsAndRestartGameScript instance1;

    public GameObject optionsCanvas;
    public void Awake()
    {
        instance1 = this;
    }
    public void Start()
    {
        
        optionsCanvas.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ButtonPressed()
    {   
        optionsCanvas.SetActive(true);
        stopwatch.instance.timeGoBrr = false;
    }
    
}
