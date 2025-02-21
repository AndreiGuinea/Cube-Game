using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptiuniScript : MonoBehaviour
{
    public void PauseResume()
    {
        PauseGameOptionsAndRestartGameScript.instance1.Start();
        stopwatch.instance.timeGoBrr = true;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("main menu");
    }

    

}
