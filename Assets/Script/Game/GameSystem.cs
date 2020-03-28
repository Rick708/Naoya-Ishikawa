using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public GameObject Mole;
    void Start()
    {

    }

    public void OnStartButton()
    {
        EncountMole();
    }

    void EncountMole()
    {
        Debug.Log("mogura");
        Instantiate(Mole);
    }

    //ステージ変更
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");// 指定したシーンに移動
    }
    public void OnHistoryButton()
    {
        SceneManager.LoadScene("History");
    }
}
