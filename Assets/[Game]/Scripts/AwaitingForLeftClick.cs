using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaitingForLeftClick : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !MenuButton.isGamePaused)
        {
            Time.timeScale = 1;
        } 
    }

}
