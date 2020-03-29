using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{

    public GameObject Mole;
    public GameObject TitleButton;
    public GameObject GameButton;
    public GameObject HistoryButton;
    MoleManager moleManager;

    //初期設定
    void Start()
    {

        TitleButton.SetActive(false);
        GameButton.SetActive(false);
        HistoryButton.SetActive(false);
        //moleManager.AddEventListenerOnTap(MoleTap);
    }

    //ゲームスタート
    public void OnStartButton()
    {
        //制限時間スタート
        EncountMole();
    }
    //モグラ遭遇
    void EncountMole()
    {
        //３体を場所固定のランダム生成したい。
        //最終的には確率でレアモグラも生成
        Mole = Instantiate(Mole);

    }
    //タップされた時のアクション
    //画像を消す、点数をつける

    public void 

    void MoleTap(MoleManager moleManager)
    {
        moleManager.AddEventListenerOnTap(MoleTap);
        Debug.Log("いけた！！");
        Destroy(Mole.gameObject);
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
    public void OnGameButton()
    {
        //ゲームのスタート画面に戻りたい。
    }
}
