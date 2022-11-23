using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HideInformationText : MonoBehaviour
{
    public GameObject InformationPanel;
    void Awake()
    {
        InformationPanel.SetActive(true);
    }

    
    void Update()
    {
        HideText();
    }

    void HideText()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InformationPanel.SetActive(false);
        }
        
    }
}
