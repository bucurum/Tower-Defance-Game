using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] Tower towerPrefab1;
    [SerializeField] Tower towerPrefab2;
    [SerializeField] Tower towerPrefab3;

    public static int towerID;
    
    [SerializeField] bool isPlaceable;
    bool isPlaced;
    
    public GameObject Xicon;
    

    float cooldown = 1.5f;

    public bool IsPlaceable { get { return isPlaceable; } }
    public Vector3 tempPosition;

    void OnMouseDown()
    {
        switch(towerID)
        {
            case 0:
                Debug.Log("Please Choose A Tower");
                break;
            case 1:
                InstantiateTower(towerPrefab);
                Debug.Log("towerprefab is placed");
                break;
            case 2:
                InstantiateTower(towerPrefab1);
                Debug.Log("towerprefab1 is placed");
                break;
            case 3:
                InstantiateTower(towerPrefab2);
                Debug.Log("towerprefab2 is placed");
                break;
            case 4:
                InstantiateTower(towerPrefab3);
                Debug.Log("towerprefab3 is placed");
                break;
        }
        
    }
    public void InstantiateTower(Tower tower)
    {
        if (isPlaceable)
        {
            isPlaced = tower.CreateTower(tower, transform.position);   
            isPlaceable = !isPlaced;
        }else
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                Destroy(Instantiate(Xicon, transform.position , Quaternion.identity), cooldown);   
            } 
        }
    }
}
