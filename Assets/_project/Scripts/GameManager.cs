using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Range(0,5)] public float timer;
    private bool timerON;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerON)
        {
            if (timer > 0.0f) 
            {
                timer -= Time.deltaTime;
            }
            else
            {
                timer = 0f;
                timerON= false;
            }
        }
    }
 
}
