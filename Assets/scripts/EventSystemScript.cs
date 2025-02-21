using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventSystemScript : MonoBehaviour
{
    // Update is called once per frame
    public void Update()
    {
        if (gameObject.scene.isLoaded)
        {
            gameObject.SetActive(true);
        }
        else gameObject.SetActive(false);
    }
}
