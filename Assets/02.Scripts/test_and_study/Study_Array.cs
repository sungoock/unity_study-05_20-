using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Study_Array : MonoBehaviour
{
    //public <-없을 경우 unity에서 접근 불가 
    int[] array_number = new int[5] { 1,2,3,4,5};

    public int num1 = 1;//public 멤버변수 - 어디서나 접근 가능
    protected int num2 = 2;//protected 멤버변수 상속자 접근 가능
    private int num3 = 3;//private 멤버변수 본인 접근 가능
    [SerializeField]
    int num4 = 4;//SerializedField에 있는 멤버변수 본인 및 unity에서 접근 가능


    List<int> list_num = new List<int>();
    void Start()
    {
        Debug.Log($"Array의 첫번째 값:{array_number[0]}"); 
        Debug.Log($"Array의 세번째 값:{array_number[2]}"); 
        //Debug.Log($"Array의 여섯번째 값:{array_number[5]}");
        //unity에서 접근 불가능 할경우 인덱스 문제로 해당 위치 오류 발생

        list_num.Add(1);
        list_num.Add(2);
        list_num.Add(3);
        list_num.Add(4);
        list_num.Add(5);
        Debug.Log($"현재 list의 데이터 수:{list_num.Count}");
        Debug.Log($"현재 list의 마지막 데이터:{list_num[list_num.Count-1]}");

    }

    // Update is called once per frame
}
