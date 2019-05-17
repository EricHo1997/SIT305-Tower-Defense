using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopsControlScipt : MonoBehaviour
{
    int moneyAmount;
    public Text moneyAmountText;
    public Button buyButton;

    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    // Update is called once per frame
    void Update()
    {
        moneyAmountText.text = "Money: " + moneyAmount.ToString() + " TD";

        if (moneyAmount >= 0)
        {
            buyButton.interactable = true;
        }
        
    }

    public void buyItems1()
    {
        moneyAmount += 100;
    }

    public void buyItems2()
    {
        moneyAmount += 550;

    }

    public void buyItems3()
    {
        moneyAmount += 880;
    }

    public void buyItems4()
    {
        moneyAmount += 1660;
    }

    public void buyItems5()
    {
        moneyAmount += 3320;
    }

    public void buyItems6()
    {
        moneyAmount += 11000;
    }

}
