using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 250;
    [SerializeField] int finisingBalance;
    int currentBalance;
    [SerializeField] TextMeshProUGUI displayBalance;    

    public int CurrentBalance { get { return currentBalance; }}

    void Awake()
    {
        currentBalance = startingBalance;
        UpdateDisplay();
    }
    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
        if (currentBalance >= finisingBalance)
        {
            LoadNextScene();
        }
    }

    void UpdateDisplay()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();
        if (currentBalance < 0)
        {
            ReloadScene();
        } 
    }

    void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
        
    }

    void LoadNextScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex + 1);   
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            currentBalance = 500;
            UpdateDisplay();
        }
        if (Input.GetKey(KeyCode.N))
        {
            LoadNextScene();
        }
    }
    
}
