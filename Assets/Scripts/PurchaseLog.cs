using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCoinButton;
    public GameObject AutoCoinButtonText;
    public GameObject FakeAutoCoinButton;
    public GameObject FakeAutoCoinButtonText;
    public GameObject ClickingMultiplierButton;
    public GameObject ClickingMultiplierButtonText;
    public GameObject FakeClickingMultiplierButton;
    public GameObject FakeClickingMultiplierButtonText;
    public GameObject AutoWoodButton;
    public GameObject AutoWoodButtonText;
    public GameObject FakeAutoWoodButton;
    public GameObject FakeAutoWoodButtonText;
    public GameObject AutoStoneButton;
    public GameObject AutoStoneButtonText;
    public GameObject FakeAutoStoneButton;
    public GameObject FakeAutoStoneButtonText;
    public GameObject AutoCoinStatDisplay;
    public GameObject AutoWoodStatDisplay;
    public GameObject AutoStoneStatDisplay;
    public GameObject ClickingMultiplierStatDisplay;
    public static int AutoCoinUnlockAmount = 50;
    public float InternalAutoCoinUnlockAmount;
    public float InternalCoin;
    public static int ClickingMultiplierUnlockAmount = 25;
    public float InternalClickingMultiplierUnlockAmount;
    public static int AutoWoodUnlockAmount = 500;
    public float InternalAutoWoodUnlockAmount;
    public float InternalWood;
    public static int AutoStoneUnlockAmount = 5000;
    public float InternalAutoStoneUnlockAmount;
    public static int AutoStoneWoodUnlockAmount = 1000;
    public float InternalAutoStoneWoodUnlockAmount;
    public float InternalStone;

    private void Start()
    {
        AutoCoinButton.SetActive(false);
        AutoWoodButton.SetActive(false);
        AutoStoneButton.SetActive(false);
    }

    public void Update()
    {

        InternalCoin = GlobalCount.CoinCount;
        InternalWood = GlobalCount.WoodCount;
        InternalStone = GlobalCount.StoneCount;

        //ClickMultiplier

        InternalClickingMultiplierUnlockAmount = ClickingMultiplierUnlockAmount;
        ClickingMultiplierButtonText.GetComponent<Text>().text = "Clicking Multiplier - " + InternalClickingMultiplierUnlockAmount + " Coins";
        FakeClickingMultiplierButtonText.GetComponent<Text>().text = "Clicking Multiplier - " + InternalClickingMultiplierUnlockAmount + " Coins";
        ClickingMultiplierStatDisplay.GetComponent<Text>().text = "Level: " + "CPS: ";

        if (InternalCoin >= InternalClickingMultiplierUnlockAmount)
        {
            FakeClickingMultiplierButton.SetActive(false);
            ClickingMultiplierButton.SetActive(true);
        }
        else
        {
            FakeClickingMultiplierButton.SetActive(true);
            ClickingMultiplierButton.SetActive(false);
        }

        //Coins

        InternalAutoCoinUnlockAmount = AutoCoinUnlockAmount;
        AutoCoinButtonText.GetComponent<Text>().text = "Auto Clicker - " + InternalAutoCoinUnlockAmount + " Coins";
        FakeAutoCoinButtonText.GetComponent<Text>().text = "Auto Clicker - " + InternalAutoCoinUnlockAmount + " Coins";
        AutoCoinStatDisplay.GetComponent<Text>().text = "Level: " + AutoCoins.AutoCoinStatLevel + " CPS: " + AutoCoins.InternalCoinIncrease;

        if (InternalCoin >= InternalAutoCoinUnlockAmount)
        {
            FakeAutoCoinButton.SetActive(false);
            AutoCoinButton.SetActive(true);
        }
        else
        {
            FakeAutoCoinButton.SetActive(true);
            AutoCoinButton.SetActive(false);
        }

        //Wood

        InternalAutoWoodUnlockAmount = AutoWoodUnlockAmount;
        AutoWoodButtonText.GetComponent<Text>().text = "Auto Wood - " + InternalAutoWoodUnlockAmount + " Coins";
        FakeAutoWoodButtonText.GetComponent<Text>().text = "Auto Wood - " + InternalAutoWoodUnlockAmount + " Coins";
        AutoWoodStatDisplay.GetComponent<Text>().text = "Level: " + AutoWood.AutoWoodStatLevel + " CPS: " + AutoWood.InternalWoodIncrease;

        if (InternalCoin >= InternalAutoWoodUnlockAmount)
        {
            FakeAutoWoodButton.SetActive(false);
            AutoWoodButton.SetActive(true);
        }
        else
        {
            FakeAutoWoodButton.SetActive(true);
            AutoWoodButton.SetActive(false);
        }

        //Stone

        InternalAutoStoneUnlockAmount = AutoStoneUnlockAmount;
        InternalAutoStoneWoodUnlockAmount = AutoStoneWoodUnlockAmount;
        AutoStoneButtonText.GetComponent<Text>().text = "Auto Stone - " + InternalAutoStoneUnlockAmount + " Coins & " + InternalAutoStoneWoodUnlockAmount + " Wood";
        FakeAutoStoneButtonText.GetComponent<Text>().text = "Auto Stone " + InternalAutoStoneUnlockAmount + " Coins & " + InternalAutoStoneWoodUnlockAmount + " Wood";
        AutoStoneStatDisplay.GetComponent<Text>().text = "Level: " + AutoStone.AutoStoneStatLevel + " CPS: " + AutoStone.InternalStoneIncrease;

        if (InternalCoin >= InternalAutoStoneUnlockAmount && InternalWood >= InternalAutoStoneWoodUnlockAmount)
        {
            FakeAutoStoneButton.SetActive(false);
            AutoStoneButton.SetActive(true);
        }
        else
        {
            FakeAutoStoneButton.SetActive(true);
            AutoStoneButton.SetActive(false);
        }
    }
}