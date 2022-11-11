using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] bool isPlaceable;
    WheelButtonHandler wheelButtonHandler;
    public GameObject Xicon;

    float cooldown = 1.5f;

    public bool IsPlaceable { get { return isPlaceable; } }

    void Start()
    {
       // showHideXIcon = GetComponent<ShowHideXIcon>();
    }

    void OnMouseDown()
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
