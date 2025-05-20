using UnityEngine;

public class Study_class
{
    public int number;
    public Study_class(int num) { number = num; }
}

public struct Study_struct
{
    public int number;
    public Study_struct(int num) { number = num; }
}
public class Study_MemoryStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("클래스 -----------------------");
        Study_class c1 = new Study_class(10);
        Study_class c2 = c1;
        c2.number = 30;
        Debug.Log($"c1:{c1.number} c2:{c2.number}");

        Debug.Log("구조체 -----------------------");
        Study_struct s1=new Study_struct(10);
        Study_struct s2 = s1;
        s2.number = 30;
        Debug.Log($"s1:{s1.number} c2:{s2.number}");

    }

    // Update is called once per frame
}
