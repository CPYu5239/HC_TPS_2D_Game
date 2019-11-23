using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int scored = 0;
    [Header("最高分數")]
    public int best;
    //GameObject可存放場景上的遊戲物件以及專案內的預置物
    private GameObject Pipe;
    private Transform Bird;

    private void Start()
    {
        //重複調用(要調用的"方法名稱",開始時間,間隔時間)
        InvokeRepeating("SpawnPipe", 0, 3f);

        //專案內的預置物取得方法要用Resources.Load("物件名稱")，但必須要將物件或欲置物放在一個Resources資料夾內。
        Pipe = (GameObject)Resources.Load("Pipe");
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
    }

    /// <summary>
    /// 判斷是否為最高分
    /// </summary>
    private void IsHeighScore()
    {
        if (scored > best)
        {
            best = scored;
        }
    }

    /// <summary>
    /// 判斷遊戲是否結束
    /// </summary>
    /// <returns>是否結束</returns>
    private bool IsOver()
    {
        bool isOver = false;
        return isOver;
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
