using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(1.0f, 10.0f)]
    public float jumpHeight = 1.0f; //跳躍高度
    [Header("是否死亡")]
    public bool death; //是否死亡

    /// <summary>
    /// 小雞跳躍的函式
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 判斷小雞是否死亡
    /// </summary>
    /// <returns>是否死亡</returns>
    private bool IsDeath()
    {

        return death;
    }
}
