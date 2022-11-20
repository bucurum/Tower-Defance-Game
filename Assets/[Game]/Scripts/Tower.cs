using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Tower : MonoBehaviour
{
    [SerializeField] int costOfTower = 75;
    
   public bool CreateTower(Tower tower, Vector3 position)
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
                Debug.Log("You Cannot Afford A Tower");
                return false;
            } 
        }
        
    return false;    
   }
}
