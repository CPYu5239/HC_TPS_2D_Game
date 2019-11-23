using UnityEngine;

public class LearnAPIs : MonoBehaviour
{
    //非靜態成員使用方法  需要先宣告欄位存放實體物件
    public Transform TR;
    //最常用
    private Camera CR;
    private AudioSource AS;

    private void Start()
    {
        //使用靜態成員(直接用) - 使用屬性
        print("隨機值 :" + Random.value);

        //使用 數學類別的PI成員
        print("PI :" + Mathf.PI);

        //使用使用靜態成員 - 方法
        print("使用方法Range :" + Random.Range(1f, 10f));

        print("使用方法絕對值 :" + Mathf.Abs(-10));

        /*非靜態成員使用方法  需要先宣告欄位存放實體物件(如宣告Public需要在Unity內部先設定，如果要在方法內宣告則不需加修飾詞，
        但要用GameObject.Find(ObjectName).GetComponent<ClassType>()來抓取專案內的物件)*/
        print("物件的座標(由Unity內部設定，不能是空值) : " + TR.position);

        //指定Unity內部的物件到CR
        CR = GameObject.Find("Main Camera").GetComponent<Camera>();
        print("Camera的深度 : " + CR.depth);

        AS = GameObject.Find("BGM").GetComponent<AudioSource>();
        AS.Stop();
    }

    /*private void Update()
    {
        //直接宣告的區域類別
        //Transform Bird = GameObject.Find("bird").GetComponent<Transform>();
    }*/
}
