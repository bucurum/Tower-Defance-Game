using UnityEngine;

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

    void HideText() //when game starts the text will be disabled
    {
        if (Input.GetMouseButtonDown(0))
        {
            InformationPanel.SetActive(false);
        }
        
    }
}
