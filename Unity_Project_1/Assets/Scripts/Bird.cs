using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(1.0f, 10.0f)]
    public float JumpHeight = 1.0f; //跳躍高度
    [Header("遊戲狀態")]
    public bool Death; //是否死亡
}
