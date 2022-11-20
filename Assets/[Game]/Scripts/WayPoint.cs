using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] Tower towerPrefab1;
    [SerializeField] bool isPlaceable;
    bool isPlaced;
    
    public GameObject Xicon;
    TowerSelectionHandler towerSelectionHandler;
    

    float cooldown = 1.5f;

    public bool IsPlaceable { get { return isPlaceable; } }
    public Vector3 tempPosition;

    void Awake()
    {
        towerSelectionHandler = GameObject.Find("TowerSelectionWheel").GetComponent<TowerSelectionHandler>();
    }
/*
findWaypoint = GameObject.FindWithTag("Enviorment");
wayPoint = findWaypoint.GetComponentInChildren<WayPoint>();
*/
    void OnMouseDown()
    {
        Debug.Log("first hello here");
       /* */
        if (isPlaceable)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                tempPosition = transform.position;
            } 
            Debug.Log("second hello here" + tempPosition);
            
            //InstantiateTower(transform.position);
        }else
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                Destroy(Instantiate(Xicon, transform.position , Quaternion.identity), cooldown);   
            }         
        }
    }
    public void InstantiateTower(Vector3 position)
    {
        /*isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);   
        isPlaceable = !isPlaced;
*/      Debug.Log("third hello here");
        switch(TowerSelectionHandler.towerID)
        {   
            case 0:
                break;
            case 1:
                Debug.Log("forth hello here");
                isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);   
                isPlaceable = !isPlaced;
                break;
            case 2:
                isPlaced = towerPrefab.CreateTower(towerPrefab1, transform.position);   
                isPlaceable = !isPlaced;
                break;
            case 3:
                Debug.Log(TowerSelectionHandler.towerID);
                break;
            case 4:
                Debug.Log(TowerSelectionHandler.towerID);
                break;
        }
    }
}
