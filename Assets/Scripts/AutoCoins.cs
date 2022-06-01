using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoins : MonoBehaviour
{
    public static bool AutoCoinEnabled = false;
    public bool InternalAutoCoinEnabled = false;
    public bool CreatingCoin = false;
    public static float CoinIncrease = 2;
    public static float InternalCoinIncrease;
    public static float CoinSeconds = 3.2f;
    public float InternalCoinSeconds;
    public float AutoCoinLevel;
    public float CoinSecondsLevel;
    public float InternalAutoCoinLevel;
    public static float AutoCoinStatLevel;
    public GameObject House;
    public GameObject House1;
    public GameObject House2;

    public void Start()
    {
        InternalCoinIncrease = CoinIncrease;
        InternalCoinSeconds = CoinSeconds;
    }

    public void ButtonPressedFirst()
    {
        if(CreatingCoin == false)
        {
            House.SetActive(true);
            AutoCoinEnabled = true;
            GlobalCount.CoinCount -= PurchaseLog.AutoCoinUnlockAmount;
            PurchaseLog.AutoCoinUnlockAmount *= 2;
            AutoCoinStatLevel += 1;
            AutoCoinLevel += 1.5f;
            CoinSecondsLevel += 0.2f;
            InternalCoinIncrease = CoinIncrease + AutoCoinLevel;
            InternalCoinSeconds = CoinSeconds - CoinSecondsLevel;
        }
    }

    public void ButtonPressed()
    {
        GlobalCount.CoinCount -= PurchaseLog.AutoCoinUnlockAmount;
        PurchaseLog.AutoCoinUnlockAmount *= 2;
        AutoCoinStatLevel += 1;
        AutoCoinLevel += 1.5f;
        CoinSecondsLevel += 0.2f;
        InternalCoinIncrease = CoinIncrease * AutoCoinLevel;
        InternalCoinSeconds = CoinSeconds - CoinSecondsLevel;
        if(AutoCoinStatLevel == 3)
        {
            House1.SetActive(true);
        }
        if(AutoCoinStatLevel == 5)
        {
            House2.SetActive(true);
        }
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
        yield return new WaitForSeconds(1); //InternalCoinSeconds
        CreatingCoin = false;
    }
}
