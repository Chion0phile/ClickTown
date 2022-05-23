using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject CastleButton;
    public GameObject MineButton;
    public GameObject SawmillButton;
    public GameObject ArmouryButton;
    public GameObject MagicShopButton;
    public GameObject PotionShopButton;

    public GameObject CastleUI;
    public GameObject CastleUIX;
    public GameObject MineUI;
    public GameObject MineUIX;
    public GameObject SawmillUI;
    public GameObject SawmillUIX;
    public GameObject ArmouryUI;
    public GameObject ArmouryUIX;
    public GameObject MagicShopUI;
    public GameObject MagicShopUIX;
    public GameObject PotionShopUI;
    public GameObject PotionShopUIX;


    public void ButtonPressedCastleButton()
    {
        CastleUI.SetActive(true);
    }

    public void ButtonPressedCastleUIXButton()
    {
        CastleUI.SetActive(false);
    }

    public void ButtonPressedMineButton()
    {
        MineUI.SetActive(true);
    }

    public void ButtonPressedMineUIXButton()
    {
        MineUI.SetActive(false);
    }

    public void ButtonPressedSawmillButton()
    {
        SawmillUI.SetActive(true);
    }

    public void ButtonPressedSawmillUIXButton()
    {
        SawmillUI.SetActive(false);
    }

    public void ButtonPressedArmouryButton()
    {
        ArmouryUI.SetActive(true);
    }

    public void ButtonPressedArmouryUIXButton()
    {
        ArmouryUI.SetActive(false);
    }

    public void ButtonPressedMagicShopButton()
    {
        MagicShopUI.SetActive(true);
    }

    public void ButtonPressedMagicShopUIXButton()
    {
        MagicShopUI.SetActive(false);
    }

    public void ButtonPressedPotionShopButton()
    {
        PotionShopUI.SetActive(true);
    }

    public void ButtonPressedPotionShopUIXButton()
    {
        PotionShopUI.SetActive(false);
    }
}
