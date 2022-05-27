using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject FirstAutoCoinButton;
    public GameObject FakeFirstAutoCoinButton;
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
    public GameObject FirstAutoWoodButton;
    public GameObject FakeFirstAutoWoodButton;
    public GameObject AutoWoodButton;
    public GameObject AutoWoodButtonText;
    public GameObject FakeAutoWoodButton;
    public GameObject FakeAutoWoodButtonText;
    public GameObject AutoWoodStatDisplay;
    public GameObject FirstAutoStoneButton;
    public GameObject FakeFirstAutoStoneButton;
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
    public GameObject MegaHitSkillBuyButton;
    public GameObject MegaHitSkillBuyButtonText;
    public GameObject FakeMegaHitSkillBuyButton;
    public GameObject FakeMegaHitSkillBuyButtonText;
    public GameObject MegaHitSkillBuyStatDisplay;
    public GameObject AddTimeSkillBuyButton;
    public GameObject AddTimeSkillBuyButtonText;
    public GameObject FakeAddTimeSkillBuyButton;
    public GameObject FakeAddTimeSkillBuyButtonText;
    public GameObject AddTimeSkillBuyStatDisplay;
    public static int AutoCoinUnlockAmount = 50;
    public float InternalAutoCoinUnlockAmount;
    public static int AutoCoinWoodUnlockAmount;
    public float InternalAutoCoinWoodUnlockAmount;
    public static int AutoCoinStoneUnlockAmount;
    public float InternalAutoCoinStoneUnlockAmount;
    public float InternalCoin;
    public static int ClickingMultiplierUnlockAmount = 25;
    public float InternalClickingMultiplierUnlockAmount;
    public static int ClickingMultiplierWoodAmount;
    public float InternalClickingMultiplierWoodAmount;
    public static int ClickingMultiplierStoneAmount;
    public float InternalClickingMultiplierStoneAmount;
    public static int AutoWoodUnlockAmount = 500;
    public float InternalAutoWoodUnlockAmount;
    public static int AutoWoodWoodUnlockAmount;
    public float InternalAutoWoodWoodUnlockAmount;
    public static int AutoWoodStoneUnlockAmount;
    public float InternalAutoWoodStoneUnlockAmount;
    public float InternalWood;
    public static int AutoStoneUnlockAmount = 5000;
    public float InternalAutoStoneUnlockAmount;
    public static int AutoStoneWoodUnlockAmount = 1000;
    public float InternalAutoStoneWoodUnlockAmount;
    public static int AutoStoneStoneUnlockAmount;
    public float InternalAutoStoneStoneUnlockAmount;
    public float InternalStone;
    public static int DPCUnlockAmount = 100;
    public float InternalDPCUnlockAmount;
    public static int DPCWoodUnlockAmount;
    public float InternalDPCWoodUnlockAmount;
    public static int DPCStoneUnlockAmount;
    public float InternalDPCStoneUnlockAmount;
    public static int DPSUnlockAmount = 200;
    public float InternalDPSUnlockAmount;
    public static int DPSWoodUnlockAmount;
    public float InternalDPSWoodUnlockAmount;
    public static int DPSStoneUnlockAmount;
    public float InternalDPSStoneUnlockAmount;
    public static int AddTimeUnlockAmount = 300;
    public float InternalAddTimeUnlockAmount;
    public static int AddTimeWoodUnlockAmount;
    public float InternalAddTimeWoodUnlockAmount;
    public static int AddTimeStoneUnlockAmount;
    public float InternalAddTimeStoneUnlockAmount;
    public static int StunSkillBuyUnlockAmount = 500;
    public float InternalStunSkillBuyUnlockAmount;
    public static int StunSkillWoodUnlockAmount;
    public float InternalStunSkillWoodUnlockAmount;
    public static int StunSkillStoneUnlockAmount;
    public float InternalStunSkillStoneUnlockAmount;
    public static int MegaHitSkillBuyUnlockAmount = 1000;
    public float InternalMegaHitSkillBuyUnlockAmount;
    public static int MegaHitSkillWoodUnlockAmount;
    public float InternalMegaHitSkillWoodUnlockAmount;
    public static int MegaHitSkillStoneUnlockAmount;
    public float InternalMegaHitSkillStoneUnlockAmount;
    public static int AddTimeSkillBuyUnlockAmount = 1000;
    public float InternalAddTimeSkillBuyUnlockAmount;
    public static int AddTimeSkillWoodUnlockAmount;
    public float InternalAddTimeSkillWoodUnlockAmount;
    public static int AddTimeSkillStoneUnlockAmount;
    public float InternalAddTimeSkillStoneUnlockAmount;

    public void Update()
    {

        InternalCoin = GlobalCount.CoinCount;
        InternalWood = GlobalCount.WoodCount;
        InternalStone = GlobalCount.StoneCount;

        //ClickMultiplier

        InternalClickingMultiplierUnlockAmount = ClickingMultiplierUnlockAmount;
        InternalClickingMultiplierWoodAmount = ClickingMultiplierWoodAmount;
        InternalClickingMultiplierStoneAmount = ClickingMultiplierStoneAmount;
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

        if(InternalCoin >= InternalAutoCoinUnlockAmount && AutoCoins.AutoCoinEnabled == false)
        {
            FakeFirstAutoCoinButton.SetActive(false);
            FirstAutoCoinButton.SetActive(true);
        }
        else
        {
            FakeFirstAutoCoinButton.SetActive(true);
            FirstAutoCoinButton.SetActive(false);
        }

        if (InternalCoin >= InternalAutoCoinUnlockAmount && AutoCoins.AutoCoinEnabled == true)
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

        if(InternalCoin >= InternalAutoWoodUnlockAmount && AutoWood.AutoWoodEnabled == false)
        {
            FakeFirstAutoWoodButton.SetActive(false);
            FirstAutoWoodButton.SetActive(true);
        }
        else
        {
            FakeFirstAutoWoodButton.SetActive(true);
            FirstAutoWoodButton.SetActive(false);
        }

        if (InternalCoin >= InternalAutoWoodUnlockAmount && AutoWood.AutoWoodEnabled == true)
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

        if(InternalCoin >= InternalAutoStoneUnlockAmount && InternalWood >= InternalAutoStoneWoodUnlockAmount && AutoStone.AutoStoneEnabled == false)
        {
            FakeFirstAutoStoneButton.SetActive(false);
            FirstAutoStoneButton.SetActive(true);
        }
        else
        {
            FakeFirstAutoStoneButton.SetActive(true);
            FirstAutoStoneButton.SetActive(false);
        }

        if (InternalCoin >= InternalAutoStoneUnlockAmount && InternalWood >= InternalAutoStoneWoodUnlockAmount && AutoStone.AutoStoneEnabled == true)
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
        InternalDPCWoodUnlockAmount = DPCWoodUnlockAmount;
        InternalDPCStoneUnlockAmount = DPCStoneUnlockAmount;
        DPCButtonText.GetComponent<Text>().text = "DPC - " + InternalDPCUnlockAmount + " Coins";
        FakeDPCButtonText.GetComponent<Text>().text = "DPC - " + InternalDPCUnlockAmount + " Coins";
        DPCStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.AutoDPCStatLevel + " DPC: " + FightManager.DPC;

        if (InternalCoin >= InternalDPCUnlockAmount && InternalCoin >= InternalDPCWoodUnlockAmount && InternalCoin >= InternalDPCStoneUnlockAmount)
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
        InternalDPSWoodUnlockAmount = DPSWoodUnlockAmount;
        InternalDPSStoneUnlockAmount = DPSStoneUnlockAmount;
        DPSButtonText.GetComponent<Text>().text = "DPS - " + InternalDPSUnlockAmount + " Coins";
        FakeDPSButtonText.GetComponent<Text>().text = "DPS - " + InternalDPSUnlockAmount + " Coins";
        DPSStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.AutoDPSStatLevel + " DPC: " + FightManager.InternalDPSIncrease;

        if (InternalCoin >= InternalDPSUnlockAmount && InternalCoin >= InternalDPSWoodUnlockAmount && InternalCoin >= InternalDPSStoneUnlockAmount)
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
        InternalAddTimeWoodUnlockAmount = AddTimeWoodUnlockAmount;
        InternalAddTimeStoneUnlockAmount = AddTimeStoneUnlockAmount;
        AddTimeButtonText.GetComponent<Text>().text = "Add Time - " + InternalAddTimeUnlockAmount + " Coins";
        FakeAddTimeButtonText.GetComponent<Text>().text = "Add Time - " + InternalAddTimeUnlockAmount + " Coins";
        AddTimeStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.AddTimeStatLevel + " Time: " + FightManager.AddTime + " Sec";

        if(InternalCoin >= InternalAddTimeUnlockAmount && InternalCoin >= InternalAddTimeWoodUnlockAmount && InternalCoin >= InternalAddTimeStoneUnlockAmount)
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
        InternalStunSkillWoodUnlockAmount = StunSkillWoodUnlockAmount;
        InternalStunSkillStoneUnlockAmount = StunSkillStoneUnlockAmount;
        StunSkillBuyButtonText.GetComponent<Text>().text = "Stun Skill - " + InternalStunSkillBuyUnlockAmount + " Coins";
        FakeStunSkillBuyButtonText.GetComponent<Text>().text = "Stun Skill - " + InternalStunSkillBuyUnlockAmount + " Coins";
        StunSkillBuyStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.StunSkillStatLevel + " Time: " + FightManager.StunDuration + " Sec";

        if(InternalCoin >= InternalStunSkillBuyUnlockAmount && InternalCoin >= InternalStunSkillWoodUnlockAmount && InternalCoin >= InternalStunSkillStoneUnlockAmount)
        {
            FakeStunSkillBuyButton.SetActive(false);
            StunSkillBuyButton.SetActive(true);
        }
        else
        {
            FakeStunSkillBuyButton.SetActive(true);
            StunSkillBuyButton.SetActive(false);
        }

        //MegaHitSkillBuy

        InternalMegaHitSkillBuyUnlockAmount = MegaHitSkillBuyUnlockAmount;
        InternalMegaHitSkillWoodUnlockAmount = MegaHitSkillWoodUnlockAmount;
        InternalMegaHitSkillStoneUnlockAmount = MegaHitSkillStoneUnlockAmount;
        MegaHitSkillBuyButtonText.GetComponent<Text>().text = "Mega Hit SKill - " + InternalMegaHitSkillBuyUnlockAmount + " Coins";
        FakeMegaHitSkillBuyButtonText.GetComponent<Text>().text = "Mega Hit Skill - " + InternalMegaHitSkillBuyUnlockAmount + " Coins";
        MegaHitSkillBuyStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.MegaHitSkillStatLevel + " Mega Hit: " + FightManager.MegaHitSkillValue + " DMG";

        if(InternalCoin >= InternalMegaHitSkillBuyUnlockAmount && InternalCoin >= InternalMegaHitSkillWoodUnlockAmount && InternalCoin >= InternalMegaHitSkillStoneUnlockAmount)
        {
            FakeMegaHitSkillBuyButton.SetActive(false);
            MegaHitSkillBuyButton.SetActive(true);
        }
        else
        {
            FakeMegaHitSkillBuyButton.SetActive(true);
            MegaHitSkillBuyButton.SetActive(false);
        }

        //AddTimeSkillBuy

        InternalAddTimeSkillBuyUnlockAmount = AddTimeSkillBuyUnlockAmount;
        InternalAddTimeSkillWoodUnlockAmount = AddTimeSkillWoodUnlockAmount;
        InternalAddTimeSkillStoneUnlockAmount = AddTimeSkillStoneUnlockAmount;
        AddTimeSkillBuyButtonText.GetComponent<Text>().text = "Add Time SKill - " + InternalAddTimeSkillBuyUnlockAmount + " Coins";
        FakeAddTimeSkillBuyButtonText.GetComponent<Text>().text = "Add Time Skill - " + InternalAddTimeSkillBuyUnlockAmount + " Coins";
        AddTimeSkillBuyStatDisplay.GetComponent<Text>().text = "Level: " + FightManager.AddTimeSkillStatLevel + " Add: " + FightManager.AddTimeSkillValue + " Sec";

        if (InternalCoin >= InternalAddTimeSkillBuyUnlockAmount && InternalCoin >= InternalAddTimeSkillWoodUnlockAmount && InternalCoin >= InternalAddTimeSkillStoneUnlockAmount)
        {
            FakeAddTimeSkillBuyButton.SetActive(false);
            AddTimeSkillBuyButton.SetActive(true);
        }
        else
        {
            FakeAddTimeSkillBuyButton.SetActive(true);
            AddTimeSkillBuyButton.SetActive(false);
        }
    }
}