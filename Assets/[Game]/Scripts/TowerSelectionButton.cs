using UnityEngine;
using TMPro;

public class TowerSelectionButton : MonoBehaviour
{
    public int ID;
    private Animator animator;
    public string itemName;
    public TextMeshProUGUI itemText;
    private bool selected = false;
    WayPoint wayPoint;
    [SerializeField] Tower towerPrefab1;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (selected) //if player didn`t selected a tower return
        {
            itemText.text = itemName;
        }
    }
    public void Selected()
    {
        selected = true;
        WayPoint.towerID = ID;
    }
    public void Deselected()
    {
        selected = false;
        WayPoint.towerID = 0;
        itemText.text = "";
    }
    public void HoverEnter()
    {
        animator.SetBool("Hover", true);
        itemText.text = itemName;
    }
    public void HoverExit()
    {
        animator.SetBool("Hover", false);
        itemText.text = "";
    }
}
