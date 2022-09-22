using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideXIcon : MonoBehaviour
{
    //you have to put x icon to every unplaceable tile and put ShowHideXIcon script to every parent tile!!!
    SpriteRenderer spriteRenderer;

    void Start()
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
    }
}
