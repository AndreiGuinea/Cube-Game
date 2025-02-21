using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    int scene;
    public static Restart instance2;

    private void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex-1;
    }
    private void Awake()
    {
        instance2 = this;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(scene);
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("main menu");
    }

}
