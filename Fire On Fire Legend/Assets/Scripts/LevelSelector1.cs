using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector1 : MonoBehaviour
{
    public SceneFader fader;
    public Button[] levelButtons;

    public int levelToUnlock = 1;

    // Update is called once per frame

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
                levelButtons[i].interactable = false;
            else if(i + 1 < levelReached)
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    levelButtons[i].interactable = true;
                }
            }
        }
    }

    public void Select(string levelName)
    {

        Debug.Log("Move to " + levelName);
        fader.FadeTo(levelName);
    }

    public void Restart()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        fader.FadeTo(SceneManager.GetActiveScene().name);
    }
}
