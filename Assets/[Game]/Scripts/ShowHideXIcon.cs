using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideXIcon : MonoBehaviour
{
    //you have to put x icon to every unplaceable tile and put ShowHideXIcon script to every parent tile!!!
    SpriteRenderer spriteRenderer;
   
   /* void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
    public void ShowXIcon()
    {
        spriteRenderer.enabled = true;
    }
    public void HideXIcon()
    {
        spriteRenderer.enabled = false;
    }*/

    /*public void CreateXIcon(ShowHideXIcon xIcon, Vector3 position)
    {
        Instantiate(xIcon, position, Quaternion.identity);
    }*/
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        
    }
}
