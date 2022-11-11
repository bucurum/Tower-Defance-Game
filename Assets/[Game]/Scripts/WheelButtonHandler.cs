using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WheelButtonHandler : MonoBehaviour
{
    public int ID;
    public string towerCost;
    public TextMeshProUGUI itemText;

    public bool selected = false;
    

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
