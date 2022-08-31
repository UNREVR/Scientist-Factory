using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SotScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool pointerEnter = false;
    public int subjectNum; //과목(1: 물리, 2: 수학, 3: 화학, 4: 생물)
    public int eraNum; //시대(1: 고대, 2: 중세, 3: 근대, 4: 현대)
    public int sexNum; //성별(1: 남성, 2: 여성)
    public int prizeNum; //상(1: 받음, 2: 못받음)
    public int regionNum; //지역(1: 동양, 2: 서양)
    public int marryNum = 1; //결혼여부(1: 미혼, 2: 1번, 3: 여러번)

    public GameObject subjectSlot, eraSlot, sexSlot, prizeSlot, regionSlot, marrySlot, marrySlot2;

    public void OnPointerEnter(PointerEventData eventData)
    {
        pointerEnter = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        pointerEnter = false;
    }

    public void AddPotion(string potionType, int num)
    {
        switch (potionType)
        {
            case "subject":
                subjectNum = num;
                subjectSlot.GetComponent<Image>().sprite =
                    GameObject.Find("potion_subject_" + num).GetComponent<Image>().sprite;
                subjectSlot.SetActive(true);
                break;
            case "era":
                eraNum = num;
                eraSlot.GetComponent<Image>().sprite =
                    GameObject.Find("potion_era_" + num).GetComponent<Image>().sprite;
                eraSlot.SetActive(true);
                break;
            case "sex":
                sexNum = num;
                sexSlot.GetComponent<Image>().sprite =
                    GameObject.Find("potion_sex_" + num).GetComponent<Image>().sprite;
                sexSlot.SetActive(true);
                break;
            case "prize":
                prizeNum = num;
                prizeSlot.GetComponent<Image>().sprite =
                    GameObject.Find("potion_prize_" + num).GetComponent<Image>().sprite;
                prizeSlot.SetActive(true);
                break;
            case "region":
                regionNum = num;
                regionSlot.GetComponent<Image>().sprite =
                    GameObject.Find("potion_region_" + num).GetComponent<Image>().sprite;
                regionSlot.SetActive(true);
                break;
            case "marry":
                switch (marryNum)
                {
                    case 1:
                        marryNum++;
                        marrySlot.GetComponent<Image>().sprite =
                            GameObject.Find("potion_marry").GetComponent<Image>().sprite;
                        marrySlot.SetActive(true);
                        break;
                    case 2:
                        marryNum++;
                        marrySlot2.GetComponent<Image>().sprite =
                            GameObject.Find("potion_marry").GetComponent<Image>().sprite;
                        marrySlot2.SetActive(true);
                        break;
                }
                break;
        }
    }

    public void ResetPotion()
    {
        subjectNum = eraNum = sexNum = prizeNum = regionNum = 0;
        marryNum = 1;
        subjectSlot.SetActive(false);
        eraSlot.SetActive(false);
        sexSlot.SetActive(false);
        prizeSlot.SetActive(false);
        regionSlot.SetActive(false);
        marrySlot.SetActive(false);
        marrySlot2.SetActive(false);
    }
}
