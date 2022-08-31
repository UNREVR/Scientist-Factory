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

        if (resultName == "nan")
        {
            resultName = "";
            description = "흐음... 포션 재료가 무언가 잘못 조합된거 같아요. 레시피를 바꿔서 다시 도전해봅시다!";
        }
        
        peopleName.GetComponent<TextMeshProUGUI>().text = resultName;
        peopleDescription.GetComponent<TextMeshProUGUI>().text = description.Replace("<br>", "\n");
        peopleImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Peoples/" + resultName);
    }
}
