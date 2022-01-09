using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoStone : MonoBehaviour
{
    public GameObject AutoStoneButton;
    public GameObject FakeAutoStoneButton;
    public static bool AutoStoneEnabled = false;
    public bool InternalAutoStoneEnabled;
    public bool CreatingStone = false;
    public static float StoneIncrease = 0.5f;
    public float InternalStoneIncrease;
    public static float StoneSeconds = 3.2f;
    public float InternalStoneSeconds;
    public float AutoStoneLevel;
    public float StoneSecondsLevel;
    public float InternalAutoStoneLevel;

    public void Start()
    {
        InternalStoneIncrease = StoneIncrease;
        InternalStoneSeconds = StoneSeconds;
    }
    public void ButtonPressed()
    {
        if (CreatingStone == false)
        {
            AutoStoneEnabled = true;
        }
        GlobalCount.CoinCount -= PurchaseLog.AutoStoneUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.AutoStoneWoodUnlockAmount;
        PurchaseLog.AutoStoneUnlockAmount *= 2;
        PurchaseLog.AutoStoneWoodUnlockAmount *= 2;
        AutoStoneLevel += 0.5f;
        StoneSecondsLevel += 0.2f;
        InternalStoneIncrease = StoneIncrease + AutoStoneLevel;
        InternalStoneSeconds = StoneSeconds - StoneSecondsLevel;
        //FakeAutoStoneButton.SetActive(true);
        //AutoStoneButton.SetActive(false);
    }
    private void Update()
    {
        InternalAutoStoneEnabled = AutoStoneEnabled;

        if (CreatingStone == false && InternalAutoStoneEnabled == true)
        {
            CreatingStone = true;
            StartCoroutine(CreateStone());
        }
    }
    IEnumerator CreateStone()
    {
        GlobalCount.StoneCount += InternalStoneIncrease;
        yield return new WaitForSeconds(InternalStoneSeconds);
        CreatingStone = false;
    }

    /*public static bool AutoStoneEnabled = false;
    public bool InternalAutoStoneEnabled;
    public bool CreatingStone = false;
    public static int StoneIncrease = 1;
    public int InternalStoneIncrease;
    public float StoneSeconds;

    public void ButtonPressed()
    {
        AutoStoneEnabled = true;
    }
    private void Update()
    {
        InternalStoneIncrease = StoneIncrease;
        InternalAutoStoneEnabled = AutoStoneEnabled;

        if (CreatingStone == false && AutoStoneEnabled == true)
        {
            CreatingStone = true;
            StartCoroutine(CreateCoin());
        }
    }
    IEnumerator CreateCoin ()
    {
        GlobalCount.StoneCount += InternalStoneIncrease;
        yield return new WaitForSeconds(StoneSeconds);
        CreatingStone = false;
    }*/
}
