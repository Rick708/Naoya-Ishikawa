using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSystem : MonoBehaviour
{
    void Start()
    {
    }

    public void OnNewGameButton()
    {
        SceneManager.LoadScene("Game");// 指定したシーンに移動
    }
    public void OnHistoryButton()
    {
        SceneManager.LoadScene("History");
    }
}
