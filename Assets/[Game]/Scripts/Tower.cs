using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int costOfTower = 75;
   public bool CreateTower(Tower tower, Vector3 position)
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
        
        return true;
   }
}
