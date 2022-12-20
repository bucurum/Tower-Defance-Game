using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab1;
    [SerializeField] Tower towerPrefab2;
    [SerializeField] Tower towerPrefab3;
    [SerializeField] Tower towerPrefab4;
 
    [SerializeField] int costofTower1;
    [SerializeField] int costofTower2;
    [SerializeField] int costofTower3;
    [SerializeField] int costofTower4;

    public static int towerID;
    [SerializeField] bool isPlaceable;
    bool isPlaced;
    public GameObject Xicon;
    float cooldown = 1.5f;
    public bool IsPlaceable { get { return isPlaceable; } }

    [SerializeField] TextMeshProUGUI textMeshPro;
    
    void OnMouseDown()
    {
        //select tower with ID and instantiate when clicked a tile
        switch(towerID)
        {
            case 0:
                //StartCoroutine(SelecTowerText());
                break;
            case 1:
                StartCoroutine(ButtonInformation(costofTower1));
                InstantiateTower(towerPrefab1, costofTower1);
                break;
            case 2:
                StartCoroutine(ButtonInformation(costofTower2));
                InstantiateTower(towerPrefab2, costofTower2);
                break;
            case 3:
                StartCoroutine(ButtonInformation(costofTower3));
                InstantiateTower(towerPrefab3, costofTower3);
                break;
            case 4:
                StartCoroutine(ButtonInformation(costofTower4));
                InstantiateTower(towerPrefab4, costofTower4);
                break;
        }
        
    }
    public void InstantiateTower(Tower tower, int costOfTower)
    {
        if (isPlaceable)
        {
            isPlaced = tower.CreateTower(tower, transform.position, costOfTower);   
            isPlaceable = !isPlaced;
        }else
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                Destroy(Instantiate(Xicon, transform.position , Quaternion.identity), cooldown);   
            } 
        }
    }

    IEnumerator ButtonInformation(int costOfTower)
    {
        Bank bank = FindObjectOfType<Bank>();

        if (bank.CurrentBalance < costOfTower)
        {
            textMeshPro.text = "Not Enough Gold";
            yield return new WaitForSeconds(2f);
            textMeshPro.text = "";
        }
    }  
    IEnumerator SelecTowerText()
    {
        textMeshPro.text = "Please Select Tower";
        yield return new WaitForSeconds(2f);
        textMeshPro.text = "";
    } 
}
