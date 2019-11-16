using UnityEngine;

public class Pipe : Ground
{
    private void Start()
    {
        //gameObject 為此類別物件本身
        //刪除(物件,延遲時間)
        Destroy(gameObject,6);
    }
}
