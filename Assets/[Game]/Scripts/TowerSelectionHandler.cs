using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelectionHandler : MonoBehaviour
{
    public Animator animator;
    public static bool towerWheelSelected = true;
    public static int towerID;

    void Update()
    {
        OpenTowerSelectionWheel();
    }

    public void OpenTowerSelectionWheel()
    {
        if(Input.GetKey(KeyCode.Tab) || Input.GetMouseButtonDown(0))
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
    }
}
