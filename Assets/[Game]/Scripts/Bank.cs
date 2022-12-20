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
    public void Deposit(int amount) //when a tower killed an enemy it will erned amouth of gold
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
        if (currentBalance >= finisingBalance) //if our balance is equal or greater than we want load next scene
        {
            LoadNextScene();
        }
    }

    void UpdateDisplay()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }

    public void Withdraw(int amount) //when enemy reachs the end of the path deposit amouth of gold
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();
        if (currentBalance < 0) // if our balance < 0 reload the scene
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
    void Update() //that`s cheat code
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
