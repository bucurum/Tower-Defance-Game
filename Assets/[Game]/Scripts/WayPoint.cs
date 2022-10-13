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
            /*Debug.Log("ShowXicon");
            showHideXIcon.ShowXIcon();
            Debug.Log("Starting corutine");
            StartCoroutine(WaitForCoolDown());*/
        }
            
    }

  /*  IEnumerator WaitForCoolDown()
    {
        yield return new WaitForSeconds(cooldown);
        cooldown = 1.5f;
        showHideXIcon.HideXIcon();

    }*/
}
