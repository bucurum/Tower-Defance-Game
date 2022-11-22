using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class Tower : MonoBehaviour
{ 
    public bool CreateTower(Tower tower, Vector3 position, int costOfTower)
    {
       if (!EventSystem.current.IsPointerOverGameObject())
        { 
            Bank bank = FindObjectOfType<Bank>();
            if(bank == null)
            {
                return false;
            }

            if (bank.CurrentBalance >= costOfTower)
            {
                Instantiate(tower, position, Quaternion.identity);
                bank.Withdraw(costOfTower);

                return true;   
            } 
            else if (bank.CurrentBalance < costOfTower)
            {
                return false;
            } 
        }
        return false;    
    }
}
