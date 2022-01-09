using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCount : MonoBehaviour
{
    public static float CoinCount;
    public static float WoodCount;
    public static float StoneCount;
    public GameObject CoinCountDisplay;
    public GameObject WoodCountDisplay;
    public GameObject StoneCountDisplay;
    public float InternalCoin;
    public float InternalWood;
    public float InternalStone;
    private float InternalCoinDisplay;
    private float InternalWoodDisplay;
    private float InternalStoneDisplay;

    private void Update()
    {
        //Coins
        InternalCoin = CoinCount;
        InternalCoinDisplay = Mathf.Round(InternalCoin * 100f) / 100f;
        CoinCountDisplay.GetComponent<Text>().text = "Coins: " + InternalCoinDisplay;

        //Wood
        InternalWood = WoodCount;
        InternalWoodDisplay = Mathf.Round(InternalWood * 100f) / 100f;
        WoodCountDisplay.GetComponent<Text>().text = "Wood: " + InternalWoodDisplay;

        //Stone
        InternalStone = StoneCount;
        InternalStoneDisplay = Mathf.Round(InternalStone * 100f) / 100f;
        StoneCountDisplay.GetComponent<Text>().text = "Stone: " + InternalStoneDisplay;
    }
}
