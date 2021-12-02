using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoStone : MonoBehaviour
{
    public static bool AutoStoneEnabled = false;
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
    }
}
