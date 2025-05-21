using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Study_Array : MonoBehaviour
{
    //public <-���� ��� unity���� ���� �Ұ� 
    int[] array_number = new int[5] { 1,2,3,4,5};

    public int num1 = 1;//public ������� - ��𼭳� ���� ����
    protected int num2 = 2;//protected ������� ����� ���� ����
    private int num3 = 3;//private ������� ���� ���� ����
    [SerializeField]
    int num4 = 4;//SerializedField�� �ִ� ������� ���� �� unity���� ���� ����


    List<int> list_num = new List<int>();
    void Start()
    {
        Debug.Log($"Array�� ù��° ��:{array_number[0]}"); 
        Debug.Log($"Array�� ����° ��:{array_number[2]}"); 
        //Debug.Log($"Array�� ������° ��:{array_number[5]}");
        //unity���� ���� �Ұ��� �Ұ�� �ε��� ������ �ش� ��ġ ���� �߻�

        list_num.Add(1);
        list_num.Add(2);
        list_num.Add(3);
        list_num.Add(4);
        list_num.Add(5);
        Debug.Log($"���� list�� ������ ��:{list_num.Count}");
        Debug.Log($"���� list�� ������ ������:{list_num[list_num.Count-1]}");

    }

    // Update is called once per frame
}
