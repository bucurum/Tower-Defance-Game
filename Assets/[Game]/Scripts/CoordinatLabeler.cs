using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CoordinatLabeler : MonoBehaviour
{
    [SerializeField] Color defaultColor = Color.white;
    [SerializeField] Color blockedColor = Color.gray;
    
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();
    WayPoint wayPoint;
    void Awake() 
    {
        label = GetComponent<TextMeshPro>(); 
        label.enabled = false;   
        wayPoint = GetComponentInParent<WayPoint>(); 
        DisplayCoordinates();
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UptadeObjectName();
        }
        ColorCoordinates();
        ToggleLabels();
    }

    private void ColorCoordinates()
    {
        if (wayPoint.IsPlaceable)
        {
            label.color = defaultColor;
        }
        else
        {
            label.color = blockedColor;
        }
    }

    void ToggleLabels()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            label.enabled = !label.IsActive();
        }
    }

    private void DisplayCoordinates()
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        label.text = coordinates.x + ", " + coordinates.y;
    }
    
    void UptadeObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
