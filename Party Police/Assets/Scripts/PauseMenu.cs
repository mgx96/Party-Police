using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject pauseMenuUI;

    public GameObject minimapUI;

    Player player;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
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
        minimapUI.SetActive(true);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void Save()
    {
        player.SavePlayer();
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        minimapUI.SetActive(false);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Only doesn't quit because we're in Editor. Also Stefan sm...");
        Application.Quit();
    }
}
