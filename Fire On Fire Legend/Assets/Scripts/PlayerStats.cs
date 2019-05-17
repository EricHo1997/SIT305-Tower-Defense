using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 200;

    public static int Lives;
    public int startLives = 3;

    public static int Rounds;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;

        Rounds = 0;
    }
}
