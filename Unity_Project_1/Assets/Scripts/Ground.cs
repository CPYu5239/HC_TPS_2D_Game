using UnityEngine;

public class Ground : MonoBehaviour
{
    [Header("地板移動速度")]
    [Range(1, 100)]
    public int speed = 10; //地板移動速度變數(定義欄位 filed)
}
