using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] Tower towerPrefab1;
    [SerializeField] bool isPlaceable;
    
    public GameObject Xicon;
    TowerSelectionHandler towerSelectionHandler;
    GameObject findTowerSelectionHandler;

    float cooldown = 1.5f;

    public bool IsPlaceable { get { return isPlaceable; } }

    void Awake()
    {
        findTowerSelectionHandler = GameObject.Find("TowerSelectionWheel");
        towerSelectionHandler = findTowerSelectionHandler.GetComponent<TowerSelectionHandler>();
    }
/*
findWaypoint = GameObject.FindWithTag("Enviorment");
wayPoint = findWaypoint.GetComponentInChildren<WayPoint>();
*/
    void OnMouseDown()
    {
       switch (TowerSelectionHandler.towerID)
        {
            case 0:
                break;
            case 1:
                InstantiateTower(towerPrefab);
                break;
            case 2:
                InstantiateTower(towerPrefab1);
                break;
            case 3:
                Debug.Log(TowerSelectionHandler.towerID);
                break;
            case 4:
                Debug.Log(TowerSelectionHandler.towerID);
                break;
        } 
    }
    public void InstantiateTower(Tower towerPrefab)
    {
        if (isPlaceable)
            {
                bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);   
                isPlaceable = !isPlaced;
            }
            else
            {
                if (!EventSystem.current.IsPointerOverGameObject())
                Destroy(Instantiate(Xicon, transform.position , Quaternion.identity), cooldown);   
            }
    }
}
