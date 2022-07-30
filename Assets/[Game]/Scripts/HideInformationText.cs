using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HideInformationText : MonoBehaviour
{
    TextMeshPro informationText;
    void Awake()
    {
        informationText = GetComponent<TextMeshPro>();
    }

    
    void Update()
    {
        HideText();
    }

    void HideText()
    {
        if (Input.GetMouseButtonDown(0))
        {
            informationText.enabled = false;    
        }
        
    }
}
