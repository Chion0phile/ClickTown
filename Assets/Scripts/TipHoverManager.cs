using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TipHoverManager : MonoBehaviour
{
    public TextMeshProUGUI TipTextWood;
    public TextMeshProUGUI TipTextStone;
    public TextMeshProUGUI TipTextCoins;
    public RectTransform TipWindow;

    public static Action<string, Vector2> OnMouseHover;
    public static Action OnMouseLoseFocus;

    private void OnEnable()
    {
        OnMouseHover += ShowTip;
        OnMouseLoseFocus += HideTip;
    }

    private void OnDisable()
    {
        OnMouseHover -= ShowTip;
        OnMouseLoseFocus -= HideTip;
    }

    private void Start()
    {
        HideTip();
    }

    private void ShowTip(string Tip, Vector2 mousePos)
    {
        TipTextWood.text = Tip;
        TipTextStone.text = HoverTip.TipToShowStone;
        TipTextCoins.text = HoverTip.TipToShowCoins;
        //TipWindow.sizeDelta = new Vector2(TipText.preferredWidth > 200 ? 200 : TipText.preferredWidth, TipText.preferredHeight);
        TipWindow.gameObject.SetActive(true);
        TipWindow.transform.position = new Vector2(mousePos.x + TipWindow.sizeDelta.x * 1, mousePos.y - 100);
    }

    private void HideTip()
    {
        //TipText.text = default;
        TipWindow.gameObject.SetActive(false);
    }
}
