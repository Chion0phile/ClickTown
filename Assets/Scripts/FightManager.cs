using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    public static float DPC = 1;
    public float MonsterHealth = 10f;
    public float MonsterHealthMax = 10f;
    public float TimeMax = 10f;
    public float CurrentTime = 10f;
    public float StartingTime = 5f;
    public static float AddTime = 0f;

    public bool MonsterAlive = true;
    public bool HaveTime = true;
    public static bool DPSEnabled = false;
    public bool InternalDPSEnabled;
    public bool DPSActive;
    public static float DPSIncrease;
    public static float InternalDPSIncrease;
    public static float DPSSeconds = 3.2f;
    public float InternalDPSSeconds;
    public float DPSLevel;
    public float DPSSecondsLevel;
    public float InternalDPSLevel;
    public static float AutoDPSStatLevel;
    public static float AutoDPCStatLevel;
    public static float AddTimeStatLevel;
    public static float StunDuration;
    public float InternalStunDuration;
    public static float StunSkillStatLevel;
    public float StunSkillCoolDown;
    public static float MegaHitStatLevel;
    public static float MegaHitSkillValue;
    public float InternalMegaHitSkillValue;
    public static float MegaHitSkillStatLevel;
    public float MegaHitSkillCooldown;
    public static float AddTimeValue;
    public static float AddTimeSkillValue;
    public float InternalAddTimeSkillValue;
    public static float AddTimeSkillStatLevel;
    public float AddTimeSkillCooldown;

    public bool Stun = false;
    public bool StunPressed;
    public bool StunUnlock = false;
    public bool MegaHitPressed;
    public bool MegaHitUnlock = false;
    public bool AddTimeSkillPressed;
    public bool AddTimeSkillUnlock = false;

    public int Kills;
    public int KillsMax;
    public int Stage = 1;

    public Vector3 StartPosition = new Vector3(3322, 3, -208);
    public Vector3 EndPosition = new Vector3(10, 25, 3);

    public GameObject HitButton;
    public GameObject DayNightButton;
    public GameObject Camera;
    public GameObject StunSkillButton;
    public GameObject FakeStunSkillButton;
    public GameObject MegaHitSkillButton;
    public GameObject FakeMegaHitSkillButton;
    public GameObject AddTimeSkillButton;
    public GameObject FakeAddTimeSkillButton;

    public Text MonsterHealthText;
    public Text KillsCounter;
    public Text StageCounter;
    public Text TimerText;
    public Text StunSkillCooldownText;
    public Text MegaHitSkillCooldownText;
    public Text AddTimeSkillCooldownText;

    public GameObject MonsterHealthTextObject;
    public GameObject KillsCounterObject;
    public GameObject StageCounterObject;
    public GameObject TimerTextObject;
    public GameObject StunSkillCooldownTextObject;
    public GameObject MegaHitSkillCooldownTextObject;
    public GameObject AddTimeSkillCooldownTextObject;

    public GameObject ArmoryBase;
    public GameObject ArmoryUpgrade1;
    public GameObject ArmoryUpgrade2;
    public GameObject ArmoryUpgrade3;
    public GameObject ArmoryUpgrade4;

    public GameObject MagicShopBase;
    public GameObject MagicShopUpgrade1;
    public GameObject MagicShopUpgrade2;
    public GameObject MagicShopUpgrade3;
    public GameObject MagicShopUpgrade4;

    public void ButtonPressed()
    {
        MonsterHealth -= DPC;
    }

    public void DayNightCycle()
    {
        Camera.transform.position = new Vector3(10, 25, -3);
        Camera.transform.Rotate(-2, 0, 0);
        MonsterHealthTextObject.SetActive(false);
        KillsCounterObject.SetActive(false);
        StageCounterObject.SetActive(false);
        TimerTextObject.SetActive(false);
        StunSkillCooldownTextObject.SetActive(false);
        MegaHitSkillCooldownTextObject.SetActive(false);
        AddTimeSkillCooldownTextObject.SetActive(false);
    }

    public void ButtonPressedDPS()
    {
        if (DPSActive == false)
        {
            DPSEnabled = true;
        }
        GlobalCount.CoinCount -= PurchaseLog.DPSUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.DPSWoodUnlockAmount;
        GlobalCount.StoneCount -= PurchaseLog.DPSStoneUnlockAmount;
        PurchaseLog.DPSUnlockAmount *= 2;
        AutoDPSStatLevel += 1;
        DPSLevel += 0.5f;
        DPSSecondsLevel += 0.2f;
        InternalDPSIncrease = DPSIncrease + DPSLevel;
        InternalDPSSeconds = DPSSeconds - DPSSecondsLevel;

        if (DPSLevel == 0.5)
        {
            ArmoryUpgrade1.SetActive(true);
        }

        if (DPSLevel == 1)
        {
            PurchaseLog.DPSWoodUnlockAmount += 100;
            ArmoryUpgrade2.SetActive(true);
        }
        if (DPSLevel == 1.5)
        {
            PurchaseLog.DPSWoodUnlockAmount *= 2;
            PurchaseLog.DPSStoneUnlockAmount += 50;
            ArmoryUpgrade3.SetActive(true);
        }
        if (DPSLevel >= 2)
        {
            PurchaseLog.DPSWoodUnlockAmount *= 2;
            PurchaseLog.DPSStoneUnlockAmount *= 2;
            ArmoryUpgrade4.SetActive(true);
        }
    }

    public void ButtonPressedDPC()
    {
        DPC *= 2;
        GlobalCount.CoinCount -= PurchaseLog.DPCUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.DPCWoodUnlockAmount;
        GlobalCount.StoneCount -= PurchaseLog.DPCStoneUnlockAmount;
        PurchaseLog.DPCUnlockAmount *= 2;
        AutoDPCStatLevel += 1;
        if (AutoDPCStatLevel == 1)
        {
            ArmoryUpgrade1.SetActive(true);
        }
        if (AutoDPCStatLevel == 2)
        {
            PurchaseLog.DPCWoodUnlockAmount += 50;
            ArmoryUpgrade2.SetActive(true);
        }
        if (AutoDPCStatLevel == 3)
        {
            PurchaseLog.DPCWoodUnlockAmount *= 2;
            PurchaseLog.DPCStoneUnlockAmount += 25;
            ArmoryUpgrade3.SetActive(true);
        }
        if (AutoDPCStatLevel >= 4)
        {
            PurchaseLog.DPCWoodUnlockAmount *= 2;
            PurchaseLog.DPCStoneUnlockAmount *= 2;
            ArmoryUpgrade4.SetActive(true);
        }
    }

    public void ButtonPressedAddTime()
    {
        AddTime += 2f;
        GlobalCount.CoinCount -= PurchaseLog.AddTimeUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.AddTimeWoodUnlockAmount;
        GlobalCount.StoneCount -= PurchaseLog.AddTimeStoneUnlockAmount;
        PurchaseLog.AddTimeUnlockAmount *= 2;
        AddTimeStatLevel += 1;
        if (AutoDPCStatLevel == 2)
        {
            PurchaseLog.AddTimeWoodUnlockAmount += 100;
        }
        if (AutoDPCStatLevel == 3)
        {
            PurchaseLog.AddTimeWoodUnlockAmount *= 2;
            PurchaseLog.AddTimeStoneUnlockAmount += 50;
        }
        if (AutoDPCStatLevel >= 4)
        {
            PurchaseLog.AddTimeWoodUnlockAmount *= 2;
            PurchaseLog.AddTimeStoneUnlockAmount *= 2;
        }
    }

    public void ButtoPressedStunSkillBuy()
    {
        if (!StunUnlock)
        {
            StunUnlock = true;
            StunSkillButton.SetActive(true);
        }
        StunDuration += 3;
        StunSkillStatLevel++;
        GlobalCount.CoinCount -= PurchaseLog.StunSkillBuyUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.StunSkillWoodUnlockAmount;
        GlobalCount.StoneCount -= PurchaseLog.StunSkillStoneUnlockAmount;
        PurchaseLog.StunSkillBuyUnlockAmount *= 2;
        if (StunSkillStatLevel == 1)
        {
            MagicShopUpgrade1.SetActive(true);
        }
        if (StunSkillStatLevel == 2)
        {
            PurchaseLog.StunSkillWoodUnlockAmount += 100;
            MagicShopUpgrade2.SetActive(true);
        }
        if (StunSkillStatLevel == 3)
        {
            PurchaseLog.StunSkillWoodUnlockAmount *= 2;
            PurchaseLog.StunSkillStoneUnlockAmount += 50;
            MagicShopUpgrade3.SetActive(true);
        }
        if (StunSkillStatLevel >= 4)
        {
            PurchaseLog.StunSkillWoodUnlockAmount *= 2;
            PurchaseLog.StunSkillStoneUnlockAmount *= 2;
            MagicShopUpgrade4.SetActive(true);
        }
    }

    public void ButtonPressedStunSkill()
    {
        if (!StunPressed)
        {
            InternalStunDuration = StunDuration;
            StunSkillCoolDown = 60f;
            Stun = true;
            StunPressed = true;
        }
    }

    public void ButtonPressedMegaHitBuy()
    {
        if (!MegaHitUnlock)
        {
            MegaHitUnlock = true;
            MegaHitSkillButton.SetActive(true);
        }
        MegaHitSkillValue += 100;
        MegaHitStatLevel++;
        GlobalCount.CoinCount -= PurchaseLog.MegaHitSkillBuyUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.MegaHitSkillWoodUnlockAmount;
        GlobalCount.StoneCount -= PurchaseLog.MegaHitSkillStoneUnlockAmount;
        PurchaseLog.MegaHitSkillBuyUnlockAmount *= 2;
        if (MegaHitSkillStatLevel == 1)
        {
            MagicShopUpgrade1.SetActive(true);
        }
        if (MegaHitSkillStatLevel == 2)
        {
            PurchaseLog.MegaHitSkillWoodUnlockAmount += 100;
            MagicShopUpgrade2.SetActive(true);
        }
        if (MegaHitSkillStatLevel == 3)
        {
            PurchaseLog.MegaHitSkillWoodUnlockAmount *= 2;
            PurchaseLog.MegaHitSkillStoneUnlockAmount += 50;
            MagicShopUpgrade3.SetActive(true);
        }
        if (MegaHitSkillStatLevel >= 4)
        {
            PurchaseLog.MegaHitSkillWoodUnlockAmount *= 2;
            PurchaseLog.MegaHitSkillStoneUnlockAmount *= 2;
            MagicShopUpgrade4.SetActive(true);
        }
    }

    public void ButtonPressedMegaHitSkill()
    {
        if (!MegaHitPressed)
        {
            MonsterHealth -= MegaHitSkillValue;
            MegaHitSkillCooldown = 45f;
            MegaHitPressed = true;
        }
    }

    public void ButtonPressedAddTimeSkillBuy()
    {
        if (!AddTimeSkillUnlock)
        {
            AddTimeSkillUnlock = true;
            AddTimeSkillButton.SetActive(true);
        }
        AddTimeSkillValue += 15;
        AddTimeSkillStatLevel++;
        GlobalCount.CoinCount -= PurchaseLog.AddTimeSkillBuyUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.AddTimeSkillWoodUnlockAmount;
        GlobalCount.StoneCount -= PurchaseLog.AddTimeSkillStoneUnlockAmount;
        PurchaseLog.AddTimeSkillBuyUnlockAmount *= 2;
        if (AddTimeSkillStatLevel == 1)
        {
            MagicShopUpgrade1.SetActive(true);
        }
        if (AddTimeSkillStatLevel == 2)
        {
            PurchaseLog.AddTimeSkillWoodUnlockAmount += 100;
            MagicShopUpgrade2.SetActive(true);
        }
        if (AddTimeSkillStatLevel == 3)
        {
            PurchaseLog.AddTimeSkillWoodUnlockAmount *= 2;
            PurchaseLog.AddTimeSkillStoneUnlockAmount += 50;
            MagicShopUpgrade3.SetActive(true);
        }
        if (AddTimeSkillStatLevel >= 4)
        {
            PurchaseLog.AddTimeSkillWoodUnlockAmount *= 2;
            PurchaseLog.AddTimeSkillStoneUnlockAmount *= 2;
            MagicShopUpgrade4.SetActive(true);
        }
    }

    public void ButtonPressedAddTimeSkill()
    {
        CurrentTime += AddTimeSkillValue;
        AddTimeSkillCooldown = 120f;
        AddTimeSkillPressed = true;
    }

    public void Update()
    {
        if (!StunUnlock)
        {
            StunSkillButton.SetActive(false);
            FakeStunSkillButton.SetActive(false);
            StunSkillCooldownText.text = " ";
        }
        if (StunPressed)
        {
            InternalStunDuration -= 1 * Time.deltaTime;
            StunSkillCoolDown -= 1 * Time.deltaTime;
            StunSkillCooldownText.text = "Cooldown: " + StunSkillCoolDown.ToString("0") + " Sec";
            FakeStunSkillButton.SetActive(true);
        }

        if (StunUnlock && !StunPressed)
        {
            StunSkillCooldownText.text = "Ready!";
            StunSkillButton.SetActive(true);
            FakeStunSkillButton.SetActive(false);
        }

        if (InternalStunDuration <= 0)
        {
            Stun = false;
        }

        if (StunSkillCoolDown <= 0)
        {
            StunPressed = false;
        }

        if (!Stun)
        {
            CurrentTime -= 1 * Time.deltaTime;
            TimerText.text = "Time: " + CurrentTime.ToString("0") + " Sec";
        }

        if (!MegaHitUnlock)
        {
            MegaHitSkillButton.SetActive(false);
            FakeMegaHitSkillButton.SetActive(false);
            MegaHitSkillCooldownText.text = " ";
        }

        if (MegaHitUnlock && !MegaHitPressed)
        {
            MegaHitSkillCooldownText.text = "Ready!";
            MegaHitSkillButton.SetActive(true);
            FakeMegaHitSkillButton.SetActive(false);
        }

        if (MegaHitPressed)
        {
            MegaHitSkillCooldown -= 1 * Time.deltaTime;
            MegaHitSkillCooldownText.text = "Cooldown: " + MegaHitSkillCooldown.ToString("0") + " Sec";
            FakeMegaHitSkillButton.SetActive(true);
        }

        if (MegaHitSkillCooldown <= 0)
        {
            MegaHitPressed = false;
        }

        if (!AddTimeSkillUnlock)
        {
            AddTimeSkillButton.SetActive(false);
            FakeAddTimeSkillButton.SetActive(false);
            AddTimeSkillCooldownText.text = " ";
        }

        if (AddTimeSkillUnlock && !AddTimeSkillPressed)
        {
            AddTimeSkillCooldownText.text = "Ready!";
            AddTimeSkillButton.SetActive(true);
            FakeAddTimeSkillButton.SetActive(false);
        }

        if (AddTimeSkillPressed)
        {
            AddTimeSkillCooldown -= 1 * Time.deltaTime;
            AddTimeSkillCooldownText.text = "Cooldown: " + MegaHitSkillCooldown.ToString("0") + " Sec";
            FakeAddTimeSkillButton.SetActive(true);
        }

        if (AddTimeSkillCooldown <= 0)
        {
            AddTimeSkillPressed = false;
        }

        MonsterHealthText.text = MonsterHealth + "/" + MonsterHealthMax + " HP";
        KillsCounter.text = " Kills: " + Kills + "/" + KillsMax;
        StageCounter.text = "Stage: " + Stage;

        if (CurrentTime <= 0)
        {
            HaveTime = false;
        }
        else
        {
            HaveTime = true;
        }

        if (!HaveTime)
        {
            NewMonster();
        }

        /*if (!MonsterAlive && HaveTime)
        {
            NewMonster();
        }*/

        if (MonsterAlive && MonsterHealth <= 0 && HaveTime)
        {
            Kills++;
            MonsterAlive = false;
            NewMonster();
        }

        if (Kills >= KillsMax)
        {
            Stage++;
            Kills = 0;
        }

        InternalDPSEnabled = DPSEnabled;

        if (DPSActive == false && InternalDPSEnabled == true)
        {
            DPSActive = true;
            StartCoroutine(DPSActiveGo());
        }
    }

    public void NewMonster()
    {
        MonsterHealthMax = 10 * Stage;
        MonsterHealth = MonsterHealthMax;
        CurrentTime = /*AddTime*/ + StartingTime + 5f * Stage;
        MonsterAlive = true;
        Stun = false;
    }

    IEnumerator DPSActiveGo()
    {
        MonsterHealth -= InternalDPSIncrease;
        yield return new WaitForSeconds(1); //InternalCoinSeconds
        DPSActive = false;
    }
}
