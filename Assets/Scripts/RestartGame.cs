using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReGame();
        }
        }
    public void ReGame() // tap to continue
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
