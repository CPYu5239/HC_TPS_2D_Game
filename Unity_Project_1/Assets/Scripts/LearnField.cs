using UnityEngine;

public class LearnField : MonoBehaviour
{
    /*定義欄位 Field(public ,private要記得加)
     int ,float ,string ,bool...等用來存放屬性,可以設定預設值,但還是以Unity內部屬性面板數值為主
     */
    //例如
    [Header("角色等級")]  //利用Header增加Unity內部可讀性
    public int Lv; //角色等級
    [Tooltip("角色移動速度，不要設定太高")]  //利用Tooltip可以增加Unity內部屬性的說明,滑鼠放上去就有
    [Range(0.1f, 99.9f)]  //設定屬性範圍,Unity內會多一個拖拉桿
    public float WalkingSpeed; //走路速度
    public string ItemName; //物品名稱
    public bool Mission; //任務成功與否
}
