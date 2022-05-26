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
    public static float StoneIncrease;
    public static float InternalStoneIncrease;
    public static float StoneSeconds = 3.2f;
    public float InternalStoneSeconds;
    public float AutoStoneLevel;
    public float StoneSecondsLevel;
    public float InternalAutoStoneLevel;
    public static float AutoStoneStatLevel;

    public void Start()
    {
        InternalStoneIncrease = StoneIncrease;
        InternalStoneSeconds = StoneSeconds;
    }

    public void ButtonPressedFirst()
    {
        if(CreatingStone == false)
        {
            AutoStoneEnabled = true;
            GlobalCount.CoinCount -= PurchaseLog.AutoStoneUnlockAmount;
            GlobalCount.WoodCount -= PurchaseLog.AutoStoneWoodUnlockAmount;
            PurchaseLog.AutoStoneUnlockAmount *= 2;
            PurchaseLog.AutoStoneWoodUnlockAmount *= 2;
            AutoStoneStatLevel += 1;
            AutoStoneLevel += 0.5f;
            StoneSecondsLevel += 0.2f;
            InternalStoneIncrease = StoneIncrease + AutoStoneLevel;
            InternalStoneSeconds = StoneSeconds - StoneSecondsLevel;
        }
    }

    public void ButtonPressed()
    {
        GlobalCount.CoinCount -= PurchaseLog.AutoStoneUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.AutoStoneWoodUnlockAmount;
        PurchaseLog.AutoStoneUnlockAmount *= 2;
        PurchaseLog.AutoStoneWoodUnlockAmount *= 2;
        AutoStoneStatLevel += 1;
        AutoStoneLevel += 0.5f;
        StoneSecondsLevel += 0.2f;
        InternalStoneIncrease = StoneIncrease + AutoStoneLevel;
        InternalStoneSeconds = StoneSeconds - StoneSecondsLevel;
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
        yield return new WaitForSeconds(1); //InternalStoneSeconds
        CreatingStone = false;
    }
}
