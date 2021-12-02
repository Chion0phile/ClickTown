using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWood : MonoBehaviour
{
    public static bool AutoWoodEnabled = false;
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
    }
}
