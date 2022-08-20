using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    public void OnClickStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
