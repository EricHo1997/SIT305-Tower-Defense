using UnityEngine;
using UnityEngine.SceneManagement;

public class ToolsMenu : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject settingsUI;

    public string menuSceneName = "LevelSelect";

    public SceneFader sceneFader;

    public void Setting()
    {
        ToggleSettingsMenu();
        pauseUI.SetActive(false);
    }
     
    public void Pause()
    {
        TogglePauseMenu();
        settingsUI.SetActive(false);
    }

    // Toggle for Pause Menu
    public void TogglePauseMenu()
    {
        pauseUI.SetActive(!pauseUI.activeSelf); // Disable this UI   

        if (pauseUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Retry()
    {
        TogglePauseMenu();
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        return;
    }

    public void Menu()
    {
        TogglePauseMenu();
        sceneFader.FadeTo(menuSceneName);
    }

    // Toggle for Settings Menu
    public void ToggleSettingsMenu()
    {
        settingsUI.SetActive(!settingsUI.activeSelf); // Disable this UI   

        if (settingsUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
