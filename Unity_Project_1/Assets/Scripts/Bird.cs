using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(1.0f, 1000.0f)]
    public float jumpHeight = 1.0f; //跳躍高度
    [Header("是否死亡")]
    public bool death; //是否死亡
    [Header("鋼體")]
    Rigidbody2D rig2D;
    
    /// <summary>
    /// 小雞跳躍的函式
    /// </summary>
    private void Jump()
    {
        //按下左鍵 --> 小雞往上
        //輸入.按下按鍵(案件列舉.左鍵)(手機觸控)
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rig2D = GameObject.Find("bird").GetComponent<Rigidbody2D>();
            rig2D.Sleep();
            //print("按左鍵");
            rig2D.gravityScale = 1;  //更改小雞鋼體重力指數
            rig2D.AddForce(new Vector2(0, jumpHeight));
        }
    }

    /// <summary>
    /// 判斷小雞是否死亡
    /// </summary>
    /// <returns>是否死亡</returns>
    private bool IsDeath()
    {

        return death;
    }
    

    private void Update()
    {
        Jump();
    }
}
