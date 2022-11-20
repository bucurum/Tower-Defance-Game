using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WheelButtonHandler : MonoBehaviour
{
    public int ID;
    public string towerCost;
    public TextMeshProUGUI itemText;

    public bool selected = false;
    WayPoint wayPoint;
    
    void Start() 
    {
        wayPoint = GameObject.FindGameObjectWithTag("WordTiles").GetComponent<WayPoint>();
    }
    void Update()
    {
        if (selected)
        {
            itemText.text = towerCost;
        }
    }
    public void Selected()
    {
        selected = true;
        TowerSelectionHandler.towerID = ID;
        switch (ID)
        {
            case 0:
                break;
            case 1:
                Debug.Log("Hello there" + wayPoint.tempPosition);
                wayPoint.InstantiateTower(wayPoint.tempPosition);
                Debug.Log("Bye Bye");
                break;
            case 2:
               
                break;
        }
    }
    public void Deselected()
    {
        selected = false;
        TowerSelectionHandler.towerID = 0;
    }
    
    public void HoverOver()
    {
        itemText.text = towerCost;
    }
    public void HoverExit()
    {
        itemText.text = "";
    }
    

}
