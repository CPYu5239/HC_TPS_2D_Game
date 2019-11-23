using UnityEngine;

public class Pipe : Ground
{
    private void Start()
    {
        //gameObject 為此類別物件本身
        //刪除(物件,延遲時間)
        //Destroy(gameObject,6);
    }

    //當所有相機都看不到時觸發  需要掛上Mesh Renderer元件
    private void OnBecameInvisible()
    {
        //gameObject 意味著這個物件本身(=this)
        Destroy(gameObject, 1f);
    }

    //當進到畫面時觸發 也需要掛上Mesh Renderer元件
    private void OnBecameVisible()
    {
        
    }
}
