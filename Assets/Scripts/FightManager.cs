using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    public float Dpc;
    public float MonsterHealth;
    public float MonsterHealthMax;
    public float Time;
    public float TimeMax;

    public bool MonsterAlive;

    public int Kills;
    public int KillsMax;
    public int Stage = 1;

    public GameObject HitButton;

    public Text MonsterHealthText;
    public Text KillsCounter;
    public Text StageCounter;
    public Text Timer;
    //public Text MonsterHealthMaxText;

    public void ButtonPressed()
    {
        MonsterHealth -= Dpc;
    }
    public void Update()
    {
        //Time -= Time.deltatime;

        MonsterHealthText.text = MonsterHealth + "/" + MonsterHealthMax + " HP";
        KillsCounter.text = " Kills: " + Kills + "/" + KillsMax;
        StageCounter.text = "Stage: " + Stage;
        //Timer.text = "Time: " + Time;

        if (!MonsterAlive)
        {
            NewMonster();
        }

        if(MonsterAlive && MonsterHealth <= 0)
        {
            Kills++;
            MonsterAlive = false;
        }

        if(Kills >= KillsMax)
        {
            Stage++;
            Kills = 0;
        }
    }

    public void NewMonster()
    {
        MonsterHealth = 10 * Stage;
        MonsterHealthMax = 10 * Stage;
        MonsterAlive = true;
        //Time = TimeMax;
    }
}
