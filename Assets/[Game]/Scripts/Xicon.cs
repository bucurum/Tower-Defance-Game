using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xicon : MonoBehaviour
{

    public void InstantiateXicon(GameObject xIcon)
    {
        GameObject newGameObject = Instantiate(xIcon, transform.position, Quaternion.identity);
        Destroy(newGameObject, 1.5f);
    }
}
