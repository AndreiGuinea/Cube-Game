
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class speedcube : MonoBehaviour
{
    public bool grounded = false;
    bool isControllable = true;
    public stopwatch stopwatch;
    Rigidbody rb;
    Vector3 Vec;
    bool jumpKeyWasPressed;
    [SerializeField] private AudioSource jumpSound;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Scene Level = SceneManager.GetActiveScene();
         if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            jumpKeyWasPressed = true;
        }
        if (isControllable)
        {
            if(PauseGameOptionsAndRestartGameScript.instance1.optionsCanvas.activeSelf)
            {
                Vec = transform.localPosition;
                Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 0;
                Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 0;
                transform.localPosition = Vec;
            }
            else
            if (Level != SceneManager.GetSceneByName("Level_3"))
            {
                Vec = transform.localPosition;
                Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
                Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 40;
                transform.localPosition = Vec;
            }
            else
            {
                Vec = transform.localPosition;
                Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 10;
                Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;
                transform.localPosition = Vec;
            }
            
            

            if (jumpKeyWasPressed)
            {
                if (Level == SceneManager.GetSceneByName("Level_3") || Level == SceneManager.GetSceneByName("Level_2") || PauseGameOptionsAndRestartGameScript.instance1.optionsCanvas.activeSelf)
                {
                    jumpKeyWasPressed = false;
                }
                else
                {
                    jumpSound.Play();
                    float jumpPower = 6f;
                    rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                    jumpKeyWasPressed = false;
                }
            }  
        }
    }

    void FixedUpdate()
    {   
       
        
        

    }
    
    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Finish")
        {
            FreezePlayer();
        }
    
    }
    public void FreezePlayer()
    {
        isControllable = false;

    }
    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

}

