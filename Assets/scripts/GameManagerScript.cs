using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    
    private void Awake()
    {
        bool pause = Input.GetKeyDown(KeyCode.Escape);
    }
    

    public void Update()
    {
       
        bool restart = Input.GetKeyDown(KeyCode.R);
        if (restart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        bool pause = Input.GetKeyDown(KeyCode.Escape);
        
        if (pause)
        {
            PauseGameOptionsAndRestartGameScript.instance1.optionsCanvas.SetActive(true);
            stopwatch.instance.timeGoBrr = false;
        }

       
    }


}
