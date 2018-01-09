using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{

    public float speedUpValue = 10.0f;

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(Time.timeScale == 1.0f)
            {
                Time.timeScale = speedUpValue;
            }
            else
            {
                Time.timeScale = 1.0f;
            }
        }
    }

}
