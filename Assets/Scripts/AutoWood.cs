using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWood : MonoBehaviour
{
    public GameObject AutoWoodButton;
    public GameObject FakeAutoWoodButton;
    public static bool AutoWoodEnabled = false;
    public bool InternalAutoWoodEnabled;
    public bool CreatingWood = false;
    public static float WoodIncrease;
    public static float InternalWoodIncrease;
    public static float WoodSeconds = 3.2f;
    public float InternalWoodSeconds;
    public float AutoWoodLevel;
    public float WoodSecondsLevel;
    public float InternalAutoWoodLevel;
    public static float AutoWoodStatLevel;

    public void Start()
    {
        InternalWoodIncrease = WoodIncrease;
        InternalWoodSeconds = WoodSeconds;
    }
    public void ButtonPressed()
    {
        if (CreatingWood == false)
        {
            AutoWoodEnabled = true;
        }
        GlobalCount.CoinCount -= PurchaseLog.AutoWoodUnlockAmount;
        PurchaseLog.AutoWoodUnlockAmount *= 2;
        AutoWoodStatLevel += 1;
        AutoWoodLevel += 0.5f;
        WoodSecondsLevel += 0.2f;
        InternalWoodIncrease = WoodIncrease + AutoWoodLevel;
        InternalWoodSeconds = WoodSeconds - WoodSecondsLevel;
        //FakeAutoWoodButton.SetActive(true);
        //AutoWoodButton.SetActive(false);
    }
    private void Update()
    {
        InternalAutoWoodEnabled = AutoWoodEnabled;

        if (CreatingWood == false && InternalAutoWoodEnabled == true)
        {
            CreatingWood = true;
            StartCoroutine(CreateWood());
        }
    }
    IEnumerator CreateWood()
    {
        GlobalCount.WoodCount += InternalWoodIncrease;
        yield return new WaitForSeconds(1); //InternalWoodSeconds
        CreatingWood = false;
    }

    /*    public static bool AutoWoodEnabled = false;
        public bool InternalAutoWoodEnabled;
        public bool CreatingWood = false;
        public static int WoodIncrease = 1;
        public int InternalWoodIncrease;
        public float WoodSeconds;

        public void ButtonPressed()
        {
            AutoWoodEnabled = true;
        }
        private void Update()
        {
            InternalWoodIncrease = WoodIncrease;
            InternalAutoWoodEnabled = AutoWoodEnabled;

            if (CreatingWood == false && AutoWoodEnabled == true)
            {
                CreatingWood = true;
                StartCoroutine(CreateCoin());
            }
        }
        IEnumerator CreateCoin ()
        {
            GlobalCount.WoodCount += InternalWoodIncrease;
            yield return new WaitForSeconds(WoodSeconds);
            CreatingWood = false;
        }*/
}
