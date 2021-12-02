using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    public static int ClickingMultiplier = 1;
    public int InternalClickingMultiplier;

    private void Update()
    {
        InternalClickingMultiplier = ClickingMultiplier;
    }

    public void ButtonClicked()
    {
        GlobalCount.CoinCount += InternalClickingMultiplier;
    }
}
