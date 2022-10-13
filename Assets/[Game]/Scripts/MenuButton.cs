using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public static bool isGamePaused = false;

    public GameObject pauseMenuUI;
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
    
}
