using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] bool isPlaceable;
    public GameObject Xicon;

    float cooldown = 1.5f;

   // ShowHideXIcon showHideXIcon;

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
            Destroy(Instantiate(Xicon, transform.position , Quaternion.identity), cooldown);   
        }       
    }

}
