using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public string menuSceneName = "LevelSelect";

    public string nextLevel;
    public int levelToUnlock;

    public SceneFader sceneFader;    

    public void Continue()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    } 
}