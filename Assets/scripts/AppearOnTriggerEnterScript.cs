using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnTriggerEnterScript : MonoBehaviour
{
    public GameObject uiObject;
    [SerializeField] AudioSource winSound;

    // Start is called before the first frame update
    public void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider Player)
    {
        if(Player.gameObject.tag == "Player")
        {
            winSound.Play();
            uiObject.SetActive(true);
        }
    }
}
