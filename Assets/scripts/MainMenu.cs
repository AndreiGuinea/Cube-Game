using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool Level_1 = false;
    public bool Level_2 = false;
    public bool Level_3 = false;
    public void PlayLevel1()
    {
        
        SceneManager.LoadScene("Level_1");
        Level_1 = true;
    }
    public void PlayLevel2()
    {
      
        SceneManager.LoadScene("Level_2");
        Level_2 = true;
    }
    public void PlayLevel3()
    {
        
        SceneManager.LoadScene("Level_3");
        Level_3 = true;
    }

    public void QuitGame()
    {
       
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
}
