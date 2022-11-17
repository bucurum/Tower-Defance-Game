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
    
    private void Start() {
        wayPoint = GetComponent<WayPoint>();
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
        switch (TowerSelectionHandler.towerID)
        {
            case 0:
                break;
            case 1:
                wayPoint.InstantiateTower();
                break;
            case 2:
                wayPoint.InstantiateTower();
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
