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
    public GameObject AutoCoinStatDisplay;
    public GameObject ClickingMultiplierButton;
    public GameObject ClickingMultiplierButtonText;
    public GameObject FakeClickingMultiplierButton;
    public GameObject FakeClickingMultiplierButtonText;
    public GameObject ClickingMultiplierStatDisplay;
    public GameObject AutoWoodButton;
    public GameObject AutoWoodButtonText;
    public GameObject FakeAutoWoodButton;
    public GameObject FakeAutoWoodButtonText;
    public GameObject AutoWoodStatDisplay;
    public GameObject AutoStoneButton;
    public GameObject AutoStoneButtonText;
    public GameObject FakeAutoStoneButton;
    public GameObject FakeAutoStoneButtonText;
    public GameObject AutoStoneStatDisplay;
    public GameObject DPCButton;
    public GameObject DPCButtonText;
    public GameObject FakeDPCButton;
    public GameObject FakeDPCButtonText;
    public GameObject DPCStatDisplay;
    public GameObject DPSButton;
    public GameObject DPSButtonText;
    public GameObject FakeDPSButton;
    public GameObject FakeDPSButtonText;
    public GameObject DPSStatDisplay;
    public GameObject AddTimeButton;
    public GameObject AddTimeButtonText;
    public GameObject FakeAddTimeButton;
    public GameObject FakeAddTimeButtonText;
    public GameObject AddTimeStatDisplay;
    public GameObject StunSkillBuyButton;
    public GameObject StunSkillBuyButtonText;
    public GameObject FakeStunSkillBuyButton;
    public GameObject FakeStunSkillBuyButtonText;
    public GameObject StunSkillBuyStatDisplay;
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
    public static int DPCUnlockAmount = 100;
    public float InternalDPCUnlockAmount;
    public static int DPSUnlockAmount = 200;
    public float InternalDPSUnlockAmount;
    public static int AddTimeUnlockAmount = 300;
    public float InternalAddTimeUnlockAmount;
    public static int StunSkillBuyUnlockAmount = 500;
    public float InternalStunSkillBuyUnlockAmount;

    public void Update()
    {

        InternalCoin = GlobalCount.CoinCount;
        InternalWood = GlobalCount.WoodCount;
        InternalStone = GlobalCount.StoneCount;

        //ClickMultiplier

        InternalClickingMultiplierUnlockAmount = ClickingMultiplierUnlockAmount;
        ClickingMultiplierButtonText.GetComponent<Text>().text = "Clicking Multiplier - " + InternalClickingMultiplierUnlockAmount + " Coins";
        FakeClickingMultiplierButtonText.GetComponent<Text>().text = "Clicking Multiplier - " + InternalClickingMultiplierUnlockAmount + " Coins";
        ClickingMultiplierStatDisplay.GetComponent<Text>().text = "Level: " + MainButtonClick.ClickingMultiplierStatLevel + " CPC: " + MainButtonClick.ClickingMultiplier;

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
        FakeAutoStoneButtonText.GetComponent<Text>().text = "Auto Stone - " + InternalAutoStoneUnlockAmount + " Coins & " + InternalAutoStoneWoodUnlockAmount + " Wood";
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

        //DPC

        InternalDPCUnlockAmount = DPCUnlockAmount;
        DPCButtonText.GetComponent<Text>().text = "DPC - " + InternalDPCUnlockAmount + " Coins";
        FakeDPCButtonText.GetComponent<Text>().text = "DPC - " + InternalDPCUnlockAmount + " Coins";
        DPCStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.AutoDPCStatLevel + " DPC: " + FightManager.DPC;

        if (InternalCoin >= InternalDPCUnlockAmount)
        {
            FakeDPCButton.SetActive(false);
            DPCButton.SetActive(true);
        }
        else
        {
            FakeDPCButton.SetActive(true);
            DPCButton.SetActive(false);
        }

        //DPS

        InternalDPSUnlockAmount = DPSUnlockAmount;
        DPSButtonText.GetComponent<Text>().text = "DPS - " + InternalDPSUnlockAmount + " Coins";
        FakeDPSButtonText.GetComponent<Text>().text = "DPS - " + InternalDPSUnlockAmount + " Coins";
        DPSStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.AutoDPSStatLevel + " DPC: " + FightManager.InternalDPSIncrease;

        if (InternalCoin >= InternalDPSUnlockAmount)
        {
            FakeDPSButton.SetActive(false);
            DPSButton.SetActive(true);
        }
        else
        {
            FakeDPSButton.SetActive(true);
            DPSButton.SetActive(false);
        }

        //AddTime

        InternalAddTimeUnlockAmount = AddTimeUnlockAmount;
        AddTimeButtonText.GetComponent<Text>().text = "Add Time - " + InternalAddTimeUnlockAmount + " Coins";
        FakeAddTimeButtonText.GetComponent<Text>().text = "Add Time - " + InternalAddTimeUnlockAmount + " Coins";
        AddTimeStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.AddTimeStatLevel + " Time: " + FightManager.AddTime + " Sec";

        if(InternalCoin >= InternalAddTimeUnlockAmount)
        {
            FakeAddTimeButton.SetActive(false);
            AddTimeButton.SetActive(true);
        }
        else
        {
            FakeAddTimeButton.SetActive(true);
            AddTimeButton.SetActive(false);
        }

        //StunSkillBuy

        InternalStunSkillBuyUnlockAmount = StunSkillBuyUnlockAmount;
        StunSkillBuyButtonText.GetComponent<Text>().text = "Stun Skill - " + InternalStunSkillBuyUnlockAmount + " Coins";
        FakeStunSkillBuyButtonText.GetComponent<Text>().text = "Stun Skill - " + InternalStunSkillBuyUnlockAmount + " Coins";
        StunSkillBuyStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.StunSkillStatLevel + " Time: " + FightManager.StunDuration + " Sec";

        if(InternalCoin >= InternalStunSkillBuyUnlockAmount)
        {
            FakeStunSkillBuyButton.SetActive(false);
            StunSkillBuyButton.SetActive(true);
        }
        else
        {
            FakeStunSkillBuyButton.SetActive(true);
            StunSkillBuyButton.SetActive(false);
        }
    }
}