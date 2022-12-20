using UnityEngine;
using UnityEngine.EventSystems;
public class Tower : MonoBehaviour
{ 
    public bool CreateTower(Tower tower, Vector3 position, int costOfTower)
    {
       if (!EventSystem.current.IsPointerOverGameObject()) //if the menu or any ui object is enabled we can`t click and place a tower
        { 
            Bank bank = FindObjectOfType<Bank>();
            if(bank == null)
            {
                return false;
            }

            if (bank.CurrentBalance >= costOfTower) // check the ballance if we have enough money to place a tower, if we have place a tower which tile we clicked
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
