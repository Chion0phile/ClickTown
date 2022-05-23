using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string TipToShow;
    private float TimeToWait = 0.5f;

    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(StartTimer());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        TipHoverManager.OnMouseLoseFocus();
    }

    private void ShowMessage()
    {
        TipHoverManager.OnMouseHover(TipToShow, Input.mousePosition);
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(TimeToWait);

        ShowMessage();
    }
}
