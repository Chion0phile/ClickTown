using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCount : MonoBehaviour
{
    public static int CoinCount;
    public static int WoodCount;
    public static int StoneCount;
    public GameObject CoinCountDisplay;
    public GameObject WoodCountDisplay;
    public GameObject StoneCountDisplay;
    public int InternalCoin;
    public int InternalWood;
    public int InternalStone;

    private void Update()
    {
        //Coins

        InternalCoin = CoinCount;
        CoinCountDisplay.GetComponent<Text>().text = "Coins: " + InternalCoin;

        //Wood
        InternalWood = WoodCount;
        WoodCountDisplay.GetComponent<Text>().text = "Wood: " + InternalWood;

        //Stone
        InternalStone = StoneCount;
        StoneCountDisplay.GetComponent<Text>().text = "Stone: " + InternalStone;
    }
}
