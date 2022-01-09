using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoins : MonoBehaviour
{
    public GameObject AutoCoinButton;
    public GameObject FakeAutoCoinButton;
    public static bool AutoCoinEnabled = false;
    public bool InternalAutoCoinEnabled;
    public bool CreatingCoin = false;
    public static float CoinIncrease = 0.5f;
    public float InternalCoinIncrease;
    public static float CoinSeconds = 3.2f;
    public float InternalCoinSeconds;
    public float AutoCoinLevel;
    public float CoinSecondsLevel;
    public float InternalAutoCoinLevel;

    public void Start()
    {
        InternalCoinIncrease = CoinIncrease;
        InternalCoinSeconds = CoinSeconds;
    }
    public void ButtonPressed()
    {
        if(CreatingCoin == false)
        {
            AutoCoinEnabled = true;
        }
        GlobalCount.CoinCount -= PurchaseLog.AutoCoinUnlockAmount;
        PurchaseLog.AutoCoinUnlockAmount *= 2;
        AutoCoinLevel += 0.5f;
        CoinSecondsLevel += 0.2f;
        InternalCoinIncrease = CoinIncrease + AutoCoinLevel;
        InternalCoinSeconds = CoinSeconds - CoinSecondsLevel;
        //FakeAutoCoinButton.SetActive(true);
        //AutoCoinButton.SetActive(false);
    }
    private void Update()
    {
        InternalAutoCoinEnabled = AutoCoinEnabled;

        if (CreatingCoin == false && InternalAutoCoinEnabled == true)
        {
            CreatingCoin = true;
            StartCoroutine(CreateCoin());
        }
    }
    IEnumerator CreateCoin ()
    {
        GlobalCount.CoinCount += InternalCoinIncrease;
        yield return new WaitForSeconds(InternalCoinSeconds);
        CreatingCoin = false;
    }
}
