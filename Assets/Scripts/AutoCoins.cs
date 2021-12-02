using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoins : MonoBehaviour
{
    public static bool AutoCoinEnabled = false;
    public bool InternalAutoCoinEnabled;
    public bool CreatingCoin = false;
    public static int CoinIncrease = 1;
    public int InternalCoinIncrease;
    public float CoinSeconds;

    public void ButtonPressed()
    {
        AutoCoinEnabled = true;
    }
    private void Update()
    {
        InternalCoinIncrease = CoinIncrease;
        InternalAutoCoinEnabled = AutoCoinEnabled;

        if (CreatingCoin == false && AutoCoinEnabled == true)
        {
            CreatingCoin = true;
            StartCoroutine(CreateCoin());
        }
    }
    IEnumerator CreateCoin ()
    {
        GlobalCount.CoinCount += InternalCoinIncrease;
        yield return new WaitForSeconds(CoinSeconds);
        CreatingCoin = false;
    }
}
