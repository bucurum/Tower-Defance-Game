using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour
{
    public static bool isGamePaused = false;

    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isGamePaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }    

    }

   public void Resume()
    {   
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false; 
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true); 
        Time.timeScale = 0f;
        isGamePaused = true;    
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }  
    
}
