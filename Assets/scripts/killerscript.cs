using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killerscript : MonoBehaviour
{
    public Scene levels;
    // Start is called before the first frame update
    void Update()
    {
        levels = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "killer" && levels == SceneManager.GetSceneByName("Level_1"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("RestartScene");

        }
        else if (other.gameObject.tag == "killer" && levels == SceneManager.GetSceneByName("Level_2"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("RestartScene2");
        }
        else if (other.gameObject.tag == "killer" && levels == SceneManager.GetSceneByName("Level_3"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("RestartScene3");
        }
    }
    
        
    
}
