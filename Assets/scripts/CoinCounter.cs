using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{   
    Text text;
    public static int coinAmount;

    public void Start()
    {
        text = GetComponent<Text>();
    }
    
    public void Update()
    {   
        text.text = coinAmount.ToString() + "/41";
        
    }
}
