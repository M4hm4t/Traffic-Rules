using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject con;

    void Start()
    {
        Pause();
    }
    // Update is called once per frame
    void Update()
    {
      
       if (Input.GetKeyDown(KeyCode.Escape))
        {
          

            if (GameIsPaused)
            {
                Resume();
                
            }
            else
            {
                Pause();
                
            }
 
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
        con.gameObject.SetActive(false);
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.000001f;
        GameIsPaused = true;
        con.gameObject.SetActive(true);
    }

  

}
