using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "MainLevel";

    public SceneFader sceneFader;

    public void PlayGame ()
    {
        sceneFader.FadeTo(levelToLoad);
        
    }


}
