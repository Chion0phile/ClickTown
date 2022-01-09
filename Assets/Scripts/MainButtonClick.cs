using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    public static float ClickingMultiplier = 1;
    public float InternalClickingMultiplier;

    private void Update()
    {
        InternalClickingMultiplier = ClickingMultiplier;
        Mathf.RoundToInt(ClickingMultiplier);
    }

    public void ButtonPressed()
    {
        ClickingMultiplier *= 1.2f;
        PurchaseLog.ClickingMultiplierUnlockAmount *= 2;
    }

    public void ButtonClicked()
    {
        GlobalCount.CoinCount += InternalClickingMultiplier;
    }
}
