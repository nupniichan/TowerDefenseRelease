using UnityEngine;

[System.Serializable]
// xoá kế thừa monobehavior là vì class này chỉ để lưu trữ thông tin nên ko cần nó
public class Wave 
{
    public GameObject enemy;
    public int count;
    public float rate;
}
