using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    Image myImageComponent;

    public static bool GameIsPaused = false;
    private bool musicIsOn = true;


    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private Sprite musicOff;
    [SerializeField] private Sprite musicOn;
   

  
    private void Start()
    {
        myImageComponent = GetComponent<Image>();
    }

    public void SetImage1()
    {
        myImageComponent.sprite = musicOn;
    }

    public void SetImage2()
    {
        myImageComponent.sprite = musicOff;
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if(musicIsOn = false)
        {
            this.GetComponent<SpriteRenderer>().sprite = musicOff;
        }
        if(musicIsOn = true)
        {
            
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    private void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


   public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        GameIsPaused = false;
    }

    public void TurnOffMusic()
    {
        musicIsOn = false;

        
    }

    public void Restart()
    {
        SceneManager.LoadScene("moveAway");
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


}
