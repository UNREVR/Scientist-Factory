using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour
{
    public GameObject peopleName, peopleImage, peopleDescription;
    // Start is called before the first frame update
    void Start()
    {
        var resultName = PlayerPrefs.GetString("ResultPeople");
        var description = PlayerPrefs.GetString("ResultDescription");
        
        peopleName.GetComponent<TextMeshProUGUI>().text = resultName;
        peopleDescription.GetComponent<TextMeshProUGUI>().text = description.Replace("<br>", "\n");
        peopleImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Peoples/" + resultName);
    }
}
