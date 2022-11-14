using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
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
       towerSelectionHandler.OpenTowerSelectionWheel();  
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
