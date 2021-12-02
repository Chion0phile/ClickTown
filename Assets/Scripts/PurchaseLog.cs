using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCoinButton;
    public GameObject AutoWoodButton;
    public GameObject AutoStoneButton;
    public GameObject ClickingMultiplierButton;
    public bool FirstTimeAutoCoin = false;
    public bool FirstTimeAutoWood = false;
    public bool FirstTimeAutoStone = false;
    public int AutoCoinUnlockAmount;
    public int AutoWoodUnlockAmount;
    public int AutoStoneUnlockAmount;

    private void Start()
    {
        AutoCoinButton.SetActive(false);
        AutoWoodButton.SetActive(false);
        AutoStoneButton.SetActive(false);
    }

    public void Update()
    {
        //Coins

        if(GlobalCount.CoinCount == AutoCoinUnlockAmount)
        {
            FirstTimeAutoCoin = true;
        }

        if (FirstTimeAutoCoin == true)
        {
            AutoCoinButton.SetActive(true);
        }

        if(AutoCoins.AutoCoinEnabled == true)
        {
            AutoCoinButton.SetActive(false);
        }

        //Wood

        if(GlobalCount.CoinCount == AutoWoodUnlockAmount)
        {
            FirstTimeAutoWood = true;
        }

        if(FirstTimeAutoWood == true)
        {
            AutoWoodButton.SetActive(true);
        }

        if(AutoWood.AutoWoodEnabled == true)
        {
            AutoWoodButton.SetActive(false);
        }

        //Stone

        if(GlobalCount.StoneCount == AutoStoneUnlockAmount)
        {
            FirstTimeAutoStone = true;
        }

        if(FirstTimeAutoStone == true)
        {
            AutoStoneButton.SetActive(true);
        }

        if(AutoStone.AutoStoneEnabled == true)
        {
            AutoStoneButton.SetActive(false);
        }
    }
}
