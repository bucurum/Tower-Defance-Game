using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelectionHandler : MonoBehaviour
{
    [SerializeField] Tower tower1;
    public Animator animator;
    public static bool towerWheelSelected = false;
    public static int towerID;
    WheelButtonHandler wheelButtonHandler;
    WayPoint wayPoint;
    GameObject findWaypoint;

    void Awake()
    {
        findWaypoint = GameObject.FindWithTag("Enviorment");
        wayPoint = findWaypoint.GetComponentInChildren<WayPoint>();
    }

    public void OpenTowerSelectionWheel()
    {
        if(Input.GetKey(KeyCode.Tab) || Input.GetMouseButton(0))
        {
            towerWheelSelected = !towerWheelSelected;
        }

        switch (towerID)
        {
            case 0:
                break;
            case 1:
                wayPoint.InstantiateTower(tower1);
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
        
        if (towerWheelSelected)
        {
            animator.SetBool("OpenWheel", true);
        }else
        {
            animator.SetBool("OpenWheel", false);
        }
    }
}
