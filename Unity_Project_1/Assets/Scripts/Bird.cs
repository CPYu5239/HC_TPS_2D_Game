﻿using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(1.0f, 1000.0f)]
    public float jumpHeight = 1.0f; //跳躍高度
    [Header("旋轉角度"), Range(0,100)]
    public float angle = 5;
    [Header("是否死亡")]
    public bool death; //是否死亡
    [Header("鋼體")]
    public Rigidbody2D rig2D;

    AudioSource aud;
    AudioClip S_jump, S_hit, S_add;

    //定義欄位或屬性時不能使用API
    //rig2D = GameObject.Find("bird").GetComponent<Rigidbody2D>();
    public GameManager gm;
    public GameObject goScore, goGM;

    /// <summary>
    /// 小雞跳躍和啟動分數、GM的函式
    /// </summary>
    private void Jump()
    {
        if (death == false)
        {
            //按下左鍵 --> 小雞往上
            //輸入.按下按鍵(案件列舉.左鍵)(手機觸控)
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                rig2D.Sleep();
                //print("按左鍵");
                rig2D.gravityScale = 1;  //更改小雞鋼體重力指數
                rig2D.AddForce(new Vector2(0, jumpHeight));  //給予小雞一個向上的力
                aud.PlayOneShot(S_jump, 1.5f); //播放音效
                //分數顯示
                goScore.SetActive(true);
                //GM啟動
                goGM.SetActive(true);
            }
            //Rigidbody2D.SetRotation(float) --> 設定角度(角度)
            //Rigidbody2D.velocity --> 加速度(二維向量 x,y) 物件往上時的加速度為+ 往下的加速度為- (範圍不知道)
            //print(rig2D.velocity);
            rig2D.SetRotation(angle * rig2D.velocity.y);  //跳躍時(+)旋轉角度並在落下時(-)轉回
        }
    }

    /// <summary>
    /// 小雞死亡,遊戲結束
    /// </summary>
    /// <returns>是否死亡</returns>
    private void Death()
    {
        //print("死");
        //print(death);
        death = true;
        gm.GameOver();  //呼叫GM裡的GameOver
    }

    //Is Trigger的物件碰撞事件
    private void OnTriggerEnter2D(Collider2D hit)
    {
        //碰撞.遊戲物件.名稱
        //print(hit.gameObject.name);
        if (hit.name == "Pipe_Down" || hit.name == "Pipe_Up")
        {
            Death();
            aud.PlayOneShot(S_hit, 1.5f);
        }
    }

    //事件 碰撞開始 - 碰撞開始時執行一次
    private void OnCollisionEnter2D(Collision2D hit)
    {
        //碰撞.遊戲物件.名稱
        //print(hit.gameObject.name);
        if (hit.gameObject.name == "地板")
        {
            Death();
            aud.PlayOneShot(S_hit, 1.5f);
        }
    }

    private void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.name == "AddPoint")
        {
            gm.AddScored();
            aud.PlayOneShot(S_add, 1.5f);
        }
    }

    //每一幀執行一次  控制物要寫在這邊
    private void Update()
    {
        Jump();
    }

    private void Start()
    {
        //將檔案指定給欄位
        S_jump = (AudioClip)Resources.Load("Sound/Jump");
        S_hit = (AudioClip)Resources.Load("Sound/Hit");
        S_add = (AudioClip)Resources.Load("Sound/Add");
        aud = GameObject.Find("bird").GetComponent<AudioSource>();
    }

}
