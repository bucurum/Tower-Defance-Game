using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
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
