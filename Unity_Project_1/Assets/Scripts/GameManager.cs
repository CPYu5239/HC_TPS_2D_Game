using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int scored = 0;
    [Header("最高分數")]
    public int best;

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
    private void AddPipe()
    {

    }
}
