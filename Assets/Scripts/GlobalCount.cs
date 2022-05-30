using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCount : MonoBehaviour
{
    public static float CoinCount = 5000;
    public static float WoodCount = 5000;
    public static float StoneCount = 5000;
    public GameObject CoinCountDisplay;
    public GameObject WoodCountDisplay;
    public GameObject StoneCountDisplay;
    public float InternalCoin;
    public float InternalWood;
    public float InternalStone;
    private float InternalCoinDisplay;
    private float InternalWoodDisplay;
    private float InternalStoneDisplay;
    public float TransitionTime = 3f;
    private float ElapsedTransitionTime;
    public GameObject DayNightButton;
    public GameObject Camera;
    public GameObject TimerText;
    public GameObject KillCounter;
    public GameObject StageCounter;
    public GameObject MonsterHealthText;
    public GameObject AddTimeSkillCooldownText;
    public GameObject StunSkillCooldownText;
    public GameObject MegaHitSkillCooldownText;


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

    public void DayNightCycle()
    {
        //ElapsedTransitionTime += Time.deltaTime;
        //float percentageComplete = ElapsedTransitionTime / TransitionTime;

        Camera.transform.position = new Vector3(3322, 25, -208);
        Camera.transform.Rotate(2, 0, 0);
        TimerText.SetActive(true);
        KillCounter.SetActive(true);
        StageCounter.SetActive(true);
        MonsterHealthText.SetActive(true);
        AddTimeSkillCooldownText.SetActive(true);
        StunSkillCooldownText.SetActive(true);
        MegaHitSkillCooldownText.SetActive(true);
    }
}
