using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartInput : MonoBehaviour
{
    void Update()
    {
        bool restart = Input.GetKeyDown(KeyCode.R);
        if (restart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
    }
}
