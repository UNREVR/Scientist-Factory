using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEngine.Networking;
using UnityEngine;

public class MakePotion : MonoBehaviour
{        
    public GameObject messageBubble;
    public void OnClickButton()
    {
        var sotScript = GameObject.Find("sot").GetComponent<SotScript>();
        var subjectNum = sotScript.subjectNum;
        var eraNum = sotScript.eraNum;
        var sexNum = sotScript.sexNum;
        var prizeNum = sotScript.prizeNum;
        var regionNum = sotScript.regionNum;
        var marryNum = sotScript.marryNum;

        if (subjectNum == 0 || eraNum == 0 || sexNum == 0 || prizeNum == 0 || regionNum == 0)
        {
            messageBubble.SetActive(true);
        }
        else
        {
            Debug.Log(marryNum);
            var peopleInfoFile = Resources.Load<TextAsset>("data");
            var sr = new StringReader(peopleInfoFile.text);
            while (true)
            {
                string[] peopleInfo = sr.ReadLine().Split('|');
                if (peopleInfo.Length < 7) break;
                if (subjectNum == Int32.Parse(peopleInfo[0])
                    && eraNum == Int32.Parse(peopleInfo[1])
                    && sexNum == Int32.Parse(peopleInfo[2])
                    && prizeNum == Int32.Parse(peopleInfo[3])
                    && regionNum == Int32.Parse(peopleInfo[4])
                    && marryNum == Int32.Parse(peopleInfo[5]))
                {
                    Debug.Log(peopleInfo[6] + ": " + peopleInfo[7]);
        
                    PlayerPrefs.SetString("ResultPeople", peopleInfo[6]);
                    PlayerPrefs.SetString("ResultDescription", peopleInfo[7]);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene("ResultScene");
                    break;
                }
            }
        }
    }
}
