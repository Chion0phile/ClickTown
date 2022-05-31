using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject Welcome;
    public GameObject WelcomeBlock;
    public GameObject CollectAsMany;
    public GameObject CollectAsManyBlock;
    public GameObject ClickAnywhere;
    public GameObject ClickAnywhereBlock;
    public GameObject EnterCastle;
    public GameObject EnterCastleBlock;
    public GameObject DayNight;
    public GameObject DayNightBlock;

    public GameObject DayNightButton;

    public static bool WelcomeShown;
    public bool WelcomeClicked;
    public static bool CollectAsManyShown;
    public bool CollectAsManyClicked;
    public static bool ClickAnywhereShown;
    public bool ClickAnywhereClicked;
    public static bool EnterCastleShown;
    public bool EnterCastleClicked;
    public static bool DayNightShown;
    public bool DayNightClicked;

    void Start()
    {
        DayNightButton.SetActive(false);
        if (!WelcomeShown)
        {
            Welcome.SetActive(true);
            WelcomeBlock.SetActive(true);
            WelcomeShown = true;
        }
    }

    public void WelcomeButtonPressed()
    {

        Welcome.SetActive(false);
        WelcomeBlock.SetActive(false);
        WelcomeClicked = true;
        ShowCollectAsMany();
    }

    public void ShowCollectAsMany()
    {
            CollectAsMany.SetActive(true);
            CollectAsManyBlock.SetActive(true);
    }

    public void CollectAsManyButtonPressed()
    {
        CollectAsMany.SetActive(false);
        CollectAsManyBlock.SetActive(false);
        CollectAsManyClicked = true;
        ShowClickAnywhere();
    }

    public void ShowClickAnywhere()
    {
        ClickAnywhere.SetActive(true);
        ClickAnywhereBlock.SetActive(true);
    }

    public void ClickAnywhereButtonPressed()
    {
        ClickAnywhere.SetActive(false);
        ClickAnywhereBlock.SetActive(false);
        ClickAnywhereClicked = true;
    }

    public void Update()
    {
        if(GlobalCount.CoinCount >= PurchaseLog.ClickingMultiplierUnlockAmount && !EnterCastleShown)
        {
            ShowEnterCastle();
        }
        if (GlobalCount.CoinCount >= 50 && !DayNightShown)
        {
            ShowDayNight();
        }
    }

    public void ShowEnterCastle()
    {
        EnterCastle.SetActive(true);
        EnterCastleBlock.SetActive(true);
        EnterCastleShown = true;
    }

    public void EnterCastleButtonPressed()
    {
        EnterCastle.SetActive(false);
        EnterCastleBlock.SetActive(false);
        EnterCastleClicked = true;
    }

    public void ShowDayNight()
    {
        DayNightButton.SetActive(true);
        DayNight.SetActive(true);
        DayNightBlock.SetActive(true);
        DayNightShown = true;
    }

    public void DayNightButtonPressed()
    {
        DayNight.SetActive(false);
        DayNightBlock.SetActive(false);
        DayNightClicked = true;
    }
}
