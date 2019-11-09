using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3, c = 10, d = 10;
    public int score = 0;
    public int num1 = 5, num2 = 10;
    public bool B1 = true, B2;
    public int HP = 75;
    public bool item = true;

    private void Start()
    {
        #region 一般運算子
        //一般運算子
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        //執行運算
        print(a++);
        print(++a);

        //運算並指定
        score += 10;
        score -= 5;
        #endregion

        #region 比較運算子
        //比較運算子
        print(num1 > num2);
        print(num1 < num2);
        print(num1 >= num2);
        print(num1 <= num2);
        print(num1 == num2);
        print(num1 != num2);
        #endregion

        #region 邏輯運算子
        //邏輯運算子 -> 且(And)
        print(B1 && B2);    //只要有F就是F
        print(true && true); //T
        print(true && false); //F
        print(false && true); //F
        print(false && false); //F

        // 或(OR)
        print(B1 || B2);    //只要有T就是T
        print(true || true); //T
        print(true || false); //T
        print(false || true); //T
        print(false || false); //F

        //可以做為過關與否的多重判斷  Ex:HP > 50 And 持有某項道具
        print(HP > 50 && item == true);

        //相反
        print(!true);   //F
        print(!false);  //T
        #endregion
    }
}

