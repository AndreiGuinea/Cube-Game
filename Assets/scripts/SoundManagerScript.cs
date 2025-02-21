using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip coinSound, powerupSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    public void Start()
    {
        coinSound = Resources.Load<AudioClip>("coin");
        powerupSound = Resources.Load<AudioClip>("powerup");
        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "coin":
                audioSrc.PlayOneShot(coinSound);

                break;
        }

        switch (clip)
        {
            case "powerup":
                audioSrc.PlayOneShot(powerupSound);

                break;
        }

    }
}
