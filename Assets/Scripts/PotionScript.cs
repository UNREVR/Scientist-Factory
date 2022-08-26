using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PotionScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public string potionType;
    public int potionNum;
    public static Vector2 DefaultPos;

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        DefaultPos = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        var sotScript = GameObject.Find("sot").GetComponent<SotScript>();
        if (sotScript.pointerEnter == true)
        {
            sotScript.AddPotion(potionType, potionNum);
            var rect = this.GetComponent<RectTransform>();
            this.transform.position = DefaultPos;
            PouringScript.Pour(this.GetComponent<Image>().sprite);
        }
        else this.transform.position = DefaultPos;
    }
}
