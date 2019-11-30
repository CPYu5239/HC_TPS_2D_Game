using UnityEngine;
using UnityEngine.UI; //引用UI
using UnityEngine.SceneManagement;  //引用場景管理

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int scored = 0;
    [Header("最高分數")]
    public int best = 0;
    //GameObject可存放場景上的遊戲物件以及專案內的預置物
    private GameObject Pipe;
    private Transform Bird;

    Text txt;
    public Text BestTxt;

    [Header("遊戲結算畫面")]
    public GameObject Over;
    //靜態成員不會出現在屬性面板(Inspector)上
    public static bool IsOver;

	//遊戲開始以及載入場景時都會執行
    private void Start()
    {
		Ground.speed = 3f;
		//設定螢幕解析度API
		Screen.SetResolution(450, 800, false);
        //重複調用(要調用的"方法名稱",開始時間,間隔時間)
        InvokeRepeating("SpawnPipe", 0, 3f);

		//靜態成員在重新載入時並不會還原,所以必須重新設定初始化
		IsOver = false;

		//利用API提取本地資料 PlayerPrefs.GetInt("變數名稱")
		best = PlayerPrefs.GetInt("Best");
		//BestTxt = GameObject.Find("Points_2").GetComponent<Text>();
		BestTxt.text = best.ToString();

        //專案內的預置物取得方法要用Resources.Load("物件名稱")，但必須要將物件或欲置物放在一個Resources資料夾內。
        Pipe = (GameObject)Resources.Load("Pipe");
        txt = GameObject.Find("Points").GetComponent<Text>();
    }

    private void Update()
    {
        Bird = GameObject.Find("bird").GetComponent<Transform>();
        //Bird.Rotate(0, 0, 1000);
    }


    /// <summary>
    /// 加分
    /// </summary>
    public void AddScored()
    {
        scored++;
        //print(scored);
        txt.text = scored.ToString();
        //IsHeighScore();
        //print(best);
		if(scored % 3 == 0 && scored > 2)
		{
			if(Ground.speed >= 10)  return;

			Ground.speed += 0.5f;
		}

    }

    /// <summary>
    /// 判斷是否為最高分
    /// </summary>
    private void IsHeighScore()
    {

        if (scored > best)
        {
            PlayerPrefs.SetInt("Best",scored);  //利用API存入本地資料設定最加分數
        }
		BestTxt.text = best.ToString();
    }

	/// <summary>
    /// 按鈕控制 - 重玩
    /// </summary>
	public void Retry()    //利用UI按鈕呼叫的方法必須為public
	{
		//Application.LoadLevel("2D_Scene_1");   //利用API  應用程式.載入("要載入的場景名稱") --> 舊版的方法
		SceneManager.LoadScene("2D_Scene_1");  //利用場景管理器載入場景
	}

	/// <summary>
    /// 按鈕控制 - 離開
    /// </summary>
	public void Quit()    //利用UI按鈕呼叫的方法必須為public
	{
		Application.Quit();  //利用API  應用程式.離開
	}

    /// <summary>
    /// 判斷遊戲是否結束
    /// </summary>
    /// <returns>是否結束</returns>
    public void GameOver()
    {
		IsHeighScore();
        Over.SetActive(true);
        IsOver = true;
        //停止重複調用的方法名稱(停止InvokeRepeating())
        CancelInvoke("SpawnPipe");
    }

    /// <summary>
    /// 生成水管
    /// </summary>
    private void SpawnPipe()
    {
        //print("生成水管");
        Vector3 pos = new Vector3(7, Random.Range(-1f,2f), 0);

        //生成(物件)
        //Quaternion.identity 代表零角度(不轉動)
        Instantiate(Pipe, pos, Quaternion.identity);
    }
}
