using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HideInformationText : MonoBehaviour
{
    public GameObject informationText;
    void Awake()
    {
        informationText.SetActive(true);
    }

    
    void Update()
    {
        HideText();
    }

    void HideText()
    {
        if (Input.GetMouseButtonDown(0))
        {
            informationText.SetActive(false);
        }
        
    }
}
