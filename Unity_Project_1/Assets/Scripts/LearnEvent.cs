using UnityEngine;

public class LearnEvent : MonoBehaviour
{
    //開始事件 遊戲開始時執行一次
    private void Start()
    {
        //使用 API 方法
        print("Hello World!!");
    }

    //更新事件 大約每秒時行60次(依照電腦效能有所差異)
    private void Update()
    {
        print("Hi!");
    }
}
