using UnityEngine;

public class Ground : MonoBehaviour
{
    [Header("地板移動速度")]
    public static float speed = 3f; //地板移動速度變數(定義欄位 filed)

    [Header("地板變型元件")]
    public Transform ground;

    private void Update()
    {
        Move();
    }

    // 方法 / 函式, Method / function
    // 修飾詞 回傳值類型 名稱() { 陳述式(敘述, 演算法) }
     
    /// <summary>
     /// 移動地板的函式
     /// </summary>
    private void Move()
    {
        if (GameManager.IsOver)
        {
            return;
        }
        //官方 API函式 -> 物件.位移(x ,y ,z)
        //Time.deltaTime -> 每幀的時間,每一台電腦都不一樣
        ground.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
