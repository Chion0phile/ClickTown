using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    public static float ClickingMultiplier = 1;
    public float InternalClickingMultiplier;
    public static float ClickingMultiplierStatLevel;

    private void Update()
    {
        InternalClickingMultiplier = ClickingMultiplier;
        Mathf.RoundToInt(ClickingMultiplier);
    }

    public void ButtonPressed()
    {
        GlobalCount.CoinCount -= PurchaseLog.ClickingMultiplierUnlockAmount;
        GlobalCount.WoodCount -= PurchaseLog.ClickingMultiplierWoodAmount;
        GlobalCount.StoneCount -= PurchaseLog.ClickingMultiplierStoneAmount;
        ClickingMultiplier *= 1.2f;
        PurchaseLog.ClickingMultiplierUnlockAmount *= 2;
        ClickingMultiplierStatLevel += 1;
    }

    public void ButtonClicked()
    {
        GlobalCount.CoinCount += InternalClickingMultiplier;
    }
}
