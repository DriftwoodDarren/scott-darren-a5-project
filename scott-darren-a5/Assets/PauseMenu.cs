using UnityEngine;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private bool isPaused;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }
    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }
}

