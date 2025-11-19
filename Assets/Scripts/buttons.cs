using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject InstruccionesPanel;
    public GameObject PausePanel;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();

    }

    public void InstruccionesOn()
    {
      InstruccionesPanel.SetActive(true);
    }
    public void InstruccionesOff()
    {
        InstruccionesPanel.SetActive(false);

    }

    private bool isPaused = false;
    public void TogglePause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
        void PauseGame()
        {
            Time.timeScale = 0f; // Detiene el tiempo del juego
            PausePanel.SetActive(true);
            isPaused = true;
            Debug.Log("Juego en pausa");
        }

        void ResumeGame()
        {
            Time.timeScale = 1f;// Restaura el tiempo normal
            PausePanel.SetActive(false);
            isPaused = false;
            Debug.Log("Juego reanudado");
        }
        // Start is called before the first frame upda
    }
        

  
    public void RetryGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
