using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TipHoverManager : MonoBehaviour
{
    public TextMeshProUGUI TipText;
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
        TipText.text = Tip;
        TipWindow.sizeDelta = new Vector2(TipText.preferredWidth > 200 ? 200 : TipText.preferredWidth, TipText.preferredHeight);
        TipWindow.gameObject.SetActive(true);
        TipWindow.transform.position = new Vector2(mousePos.x + TipWindow.sizeDelta.x * 2, mousePos.y);
    }

    private void HideTip()
    {
        TipText.text = default;
        TipWindow.gameObject.SetActive(false);
    }
}
