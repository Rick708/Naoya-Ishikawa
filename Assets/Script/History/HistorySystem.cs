using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HistorySystem : MonoBehaviour
{
    void Start()
    {
    }

    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");// 指定したシーンに移動
    }
    public void OnGameButton()
    {
        SceneManager.LoadScene("Game");
    }
}
