using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    public static float DPC = 1;
    public float MonsterHealth;
    public float MonsterHealthMax;
    public float TimeMax;
    public float CurrentTime = 1f;
    public float StartingTime = 5f;
    public static float AddTime = 0f;

    public bool MonsterAlive;
    public bool HaveTime;
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
    public bool AddTimePressed;
    public bool AddTimeUnlock = false;

    public int Kills;
    public int KillsMax;
    public int Stage = 1;

    public Vector3 StartPosition = new Vector3(2150, 250, -500);
    public Vector3 EndPosition = new Vector3(500, 250, -500);

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

    public void ButtonPressed()
    {
        MonsterHealth -= DPC;
    }

    public void DayNightCycle()
    {
        Camera.transform.position = Vector3.Lerp(StartPosition, EndPosition, 1);
    }

    public void ButtonPressedDPS()
    {
        if (DPSActive == false)
        {
            DPSEnabled = true;
        }
        GlobalCount.CoinCount -= PurchaseLog.DPSUnlockAmount;
        PurchaseLog.DPSUnlockAmount *= 2;
        AutoDPSStatLevel += 1;
        DPSLevel += 0.5f;
        DPSSecondsLevel += 0.2f;
        InternalDPSIncrease = DPSIncrease + DPSLevel;
        InternalDPSSeconds = DPSSeconds - DPSSecondsLevel;
    }

    public void ButtonPressedDPC()
    {
        DPC *= 2;
        GlobalCount.CoinCount -= PurchaseLog.DPCUnlockAmount;
        PurchaseLog.DPCUnlockAmount *= 2;
        AutoDPCStatLevel += 1;
    }

    public void ButtonPressedAddTime()
    {
        AddTime += 2f;
        GlobalCount.CoinCount -= PurchaseLog.AddTimeUnlockAmount;
        PurchaseLog.AddTimeUnlockAmount *= 2;
        AddTimeStatLevel += 1;
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
        PurchaseLog.StunSkillBuyUnlockAmount *= 2;
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
        PurchaseLog.MegaHitSkillBuyUnlockAmount *= 2;
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

    }

    public void ButtonPressedAddTimeSkill()
    {

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

        if(StunSkillCoolDown <= 0)
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

        if(MegaHitUnlock && !MegaHitPressed)
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

        if(MegaHitSkillCooldown <= 0)
        {
            MegaHitPressed = false;
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

        if (!MonsterAlive && HaveTime)
        {
            NewMonster();
        }

        if(MonsterAlive && MonsterHealth <= 0 && HaveTime)
        {
            Kills++;
            MonsterAlive = false;
        }

        if(Kills >= KillsMax)
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
        MonsterHealth = 10 * Stage;
        MonsterHealthMax = 10 * Stage;
        CurrentTime = AddTime + StartingTime + 5f * Stage;
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
