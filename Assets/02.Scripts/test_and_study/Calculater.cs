using UnityEngine;

public class Calculater : MonoBehaviour
{
    public int num1=30;
    public int num2=10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Add_Method(num1, num2));

        Debug.Log(Minus_Method(num1, num2));

    }
    int Add_Method(int  n1,int n2)
    {
        return n1+ n2;
    }
    int Minus_Method(int n1, int n2)
    {
        return n1- n2;
    }
    // Update is called once per frame
}
