using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PouringScript : MonoBehaviour
{
    public static GameObject PotionPourPrefeb;
    private static readonly int Pouring = Animator.StringToHash("Pouring");

    private void Start()
    {
        PotionPourPrefeb = Resources.Load("potion_pour") as GameObject;
    }

    public static void Pour(Sprite s)
    {
        var potionPour = Instantiate(PotionPourPrefeb, GameObject.Find("Potions").transform);
        potionPour.GetComponent<Image>().sprite = s;
        Destroy(potionPour, 2f);
    }
}
