using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool test;
    public string prop;
    public int HP = 100;
    private void Update()
    {
        #region IF判斷式語法
        //IF判斷式語法
        //if(bool == true) { 陳述式 }
        if (test)
        {
            print("打開開關~");
        }
        //(bool == false) 才執行else
        else
        {
            print("關閉開關~");
        }

        //多層判斷式
        if (prop == "red")
        {
            print("HP++");
        }
        else if(prop == "blue")
        {
            print("MP++");
        }
        else
        {
            print("啥都沒~");
        }
        #endregion

        if (HP <= 20)
        {
            print("快死了!!");
        }
        else if (HP <= 50)
        {
            print("危險!");
        }
        else if (HP <= 70)
        {
            print("警告");
        }
        else
        {
            print("沒4~");
        }
    }
}
