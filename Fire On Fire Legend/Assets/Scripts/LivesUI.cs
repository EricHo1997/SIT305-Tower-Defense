using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Text livesText;

    public GameObject heart1, heart2, heart3;

    void Start()
    {
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        switch (PlayerStats.Lives)
        {
            case 3:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                break;

            case 2:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                break;

            case 1:
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;

            case 0:
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
        }

        livesText.text = PlayerStats.Lives.ToString() + " LIVES";
    }
}
