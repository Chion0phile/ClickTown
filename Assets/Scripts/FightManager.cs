using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    public float Dpc;
    public float MonsterHealth;
    public float MonsterHealthMax;
    public float TimeMax;
    public float CurrentTime = 1f;
    public float StartingTime = 5f;

    public bool MonsterAlive;
    public bool HaveTime;

    public int Kills;
    public int KillsMax;
    public int Stage = 1;

    public Vector3 StartPosition = new Vector3(2150, 250, -500);
    public Vector3 EndPosition = new Vector3(500, 250, -500);

    public GameObject HitButton;
    public GameObject DayNightButton;
    public GameObject Camera;

    public Text MonsterHealthText;
    public Text KillsCounter;
    public Text StageCounter;
    public Text TimerText;

    public void ButtonPressed()
    {
        MonsterHealth -= Dpc;
    }

    public void DayNightCycle()
    {
        Camera.transform.position = Vector3.Lerp(StartPosition, EndPosition, 1);
    }

    public void Update()
    {
        CurrentTime -= 1 * Time.deltaTime;
        TimerText.text = "Time: " + CurrentTime.ToString ("0") + " sec";
        MonsterHealthText.text = MonsterHealth + "/" + MonsterHealthMax + " HP";
        KillsCounter.text = " Kills: " + Kills + "/" + KillsMax;
        StageCounter.text = "Stage: " + Stage;

        if (CurrentTime <= 0)
        {
            HaveTime = false;
        }
        else
        {
            HaveTime = true;
        }

        if (!HaveTime)
        {
            NewMonster();
        }

        if (!MonsterAlive && HaveTime)
        {
            NewMonster();
        }

        if(MonsterAlive && MonsterHealth <= 0 && HaveTime)
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
        CurrentTime = StartingTime + 5f * Stage;
        MonsterAlive = true;
    }
}
