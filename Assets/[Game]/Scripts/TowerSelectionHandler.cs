using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelectionHandler : MonoBehaviour
{
    public Animator animator;
    private bool towerWheelSelected = false;
    public static int towerID;
    WheelButtonHandler wheelButtonHandler;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            towerWheelSelected = !towerWheelSelected;
        }

        if (towerWheelSelected)
        {
            animator.SetBool("OpenWheel", true);
        }else
        {
            animator.SetBool("OpenWheel", false);
        }
        switch (towerID)
        {
            case 0:
                break;
            case 1:
                Debug.Log("fist tower selected");
                break;
            case 2:
                Debug.Log("second tower selected");
                break;
            case 3:
                Debug.Log("third tower selected");
                break;
            case 4:
                Debug.Log("forth tower selected");
                break;
        }
       
        
    }
}
