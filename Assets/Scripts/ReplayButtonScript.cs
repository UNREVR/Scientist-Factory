using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayButtonScript : MonoBehaviour
{
    public void OnClickReplayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScene");
    }
}
