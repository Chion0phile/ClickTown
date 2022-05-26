using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string TipToShowWood;
    public static string TipToShowStone;
    public static string TipToShowCoins;
    private float TimeToWait = 0.5f;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject != null)
        {
            //Debug.Log("Mouse Over: " + eventData.pointerCurrentRaycast.gameObject.name);
            if (eventData.pointerCurrentRaycast.gameObject.name == "MegaHitBuyButton")
            {
                TipToShowWood = PurchaseLog.MegaHitSkillWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.MegaHitSkillStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.MegaHitSkillBuyUnlockAmount.ToString();
            }
            if (eventData.pointerCurrentRaycast.gameObject.name == "FakeMegaHitBuyButton")
            {
                TipToShowWood = PurchaseLog.MegaHitSkillWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.MegaHitSkillStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.MegaHitSkillBuyUnlockAmount.ToString();
            }

            if(eventData.pointerCurrentRaycast.gameObject.name == "AddTimeSkillBuyButton")
            {
                TipToShowWood = PurchaseLog.AddTimeSkillWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AddTimeSkillStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AddTimeSkillBuyUnlockAmount.ToString();
            }
            if(eventData.pointerCurrentRaycast.gameObject.name == "FakeAddTimeSkillBuyButton")
            {
                TipToShowWood = PurchaseLog.AddTimeSkillWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AddTimeSkillStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AddTimeSkillBuyUnlockAmount.ToString();
            }

            if(eventData.pointerCurrentRaycast.gameObject.name == "StunSkillBuyButton")
            {
                TipToShowWood = PurchaseLog.StunSkillWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.StunSkillStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.StunSkillBuyUnlockAmount.ToString();
            }
            if(eventData.pointerCurrentRaycast.gameObject.name == "FakeStunSkillBuyButton")
            {
                TipToShowWood = PurchaseLog.StunSkillWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.StunSkillStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.StunSkillBuyUnlockAmount.ToString();
            }

            if(eventData.pointerCurrentRaycast.gameObject.name == "DPCBuyButton")
            {
                TipToShowWood = PurchaseLog.DPCWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.DPCStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.DPCUnlockAmount.ToString();
            }
            if(eventData.pointerCurrentRaycast.gameObject.name == "FakeDPCBuyButton")
            {
                TipToShowWood = PurchaseLog.DPCWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.DPCStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.DPCUnlockAmount.ToString();
            }

            if(eventData.pointerCurrentRaycast.gameObject.name == "DPSBuyButton")
            {
                TipToShowWood = PurchaseLog.DPSWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.DPSStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.DPSUnlockAmount.ToString();
            }
            if(eventData.pointerCurrentRaycast.gameObject.name == "FakeDPSBuyButton")
            {
                TipToShowWood = PurchaseLog.DPSWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.DPSStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.DPSUnlockAmount.ToString();
            }

            if(eventData.pointerCurrentRaycast.gameObject.name == "AddTimeBuyButton")
            {
                TipToShowWood = PurchaseLog.AddTimeWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AddTimeStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AddTimeUnlockAmount.ToString();
            }
            if(eventData.pointerCurrentRaycast.gameObject.name == "FakeAddTimeBuyButton")
            {
                TipToShowWood = PurchaseLog.AddTimeWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AddTimeStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AddTimeUnlockAmount.ToString();
            }

            if (eventData.pointerCurrentRaycast.gameObject.name == "FirstAutoCoinBuyButton" && AutoCoins.AutoCoinEnabled == false)
            {
                TipToShowWood = PurchaseLog.AutoCoinWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoCoinStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoCoinUnlockAmount.ToString();
            }
            if (eventData.pointerCurrentRaycast.gameObject.name == "FakeFirstAutoCoinBuyButton" && AutoCoins.AutoCoinEnabled == false)
            {
                TipToShowWood = PurchaseLog.AutoCoinWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoCoinStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoCoinUnlockAmount.ToString();
            }

            if(eventData.pointerCurrentRaycast.gameObject.name == "AutoCoinBuyButton" && AutoCoins.AutoCoinEnabled)
            {
                TipToShowWood = PurchaseLog.AutoCoinWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoCoinStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoCoinUnlockAmount.ToString();
            }
            if (eventData.pointerCurrentRaycast.gameObject.name == "FakeAutoCoinBuyButton" && AutoCoins.AutoCoinEnabled)
            {
                TipToShowWood = PurchaseLog.AutoCoinWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoCoinStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoCoinUnlockAmount.ToString();
            }

            if (eventData.pointerCurrentRaycast.gameObject.name == "FirstAutoWoodBuyButton" && AutoWood.AutoWoodEnabled == false)
            {
                TipToShowWood = PurchaseLog.AutoWoodWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoWoodStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoWoodUnlockAmount.ToString();
            }
            if (eventData.pointerCurrentRaycast.gameObject.name == "FakeFirstAutoWoodBuyButton" && AutoWood.AutoWoodEnabled == false)
            {
                TipToShowWood = PurchaseLog.AutoWoodWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoWoodStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoWoodUnlockAmount.ToString();
            }

            if (eventData.pointerCurrentRaycast.gameObject.name == "AutoWoodBuyButton" && AutoWood.AutoWoodEnabled)
            {
                TipToShowWood = PurchaseLog.AutoWoodWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoWoodStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoWoodUnlockAmount.ToString();
            }
            if (eventData.pointerCurrentRaycast.gameObject.name == "FakeAutoWoodBuyButton" && AutoWood.AutoWoodEnabled)
            {
                TipToShowWood = PurchaseLog.AutoWoodWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoWoodStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoWoodUnlockAmount.ToString();
            }

            if (eventData.pointerCurrentRaycast.gameObject.name == "FirstAutoStoneBuyButton" && AutoStone.AutoStoneEnabled == false)
            {
                TipToShowWood = PurchaseLog.AutoStoneWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoStoneStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoStoneUnlockAmount.ToString();
            }
            if (eventData.pointerCurrentRaycast.gameObject.name == "FakeFirstAutoStoneBuyButton" && AutoStone.AutoStoneEnabled == false)
            {
                TipToShowWood = PurchaseLog.AutoStoneWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoStoneStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoStoneUnlockAmount.ToString();
            }

            if (eventData.pointerCurrentRaycast.gameObject.name == "AutoStoneBuyButton" && AutoStone.AutoStoneEnabled)
            {
                TipToShowWood = PurchaseLog.AutoStoneWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoStoneStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoStoneUnlockAmount.ToString();
            }
            if (eventData.pointerCurrentRaycast.gameObject.name == "FakeAutoStoneBuyButton" && AutoStone.AutoStoneEnabled)
            {
                TipToShowWood = PurchaseLog.AutoStoneWoodUnlockAmount.ToString();
                TipToShowStone = PurchaseLog.AutoStoneStoneUnlockAmount.ToString();
                TipToShowCoins = PurchaseLog.AutoStoneUnlockAmount.ToString();
            }
        }
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
        TipHoverManager.OnMouseHover(TipToShowWood, Input.mousePosition);
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(TimeToWait);

        ShowMessage();
    }
}
