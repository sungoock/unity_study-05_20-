using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Study_Gameobject : MonoBehaviour
{
    public GameObject pre;
    public Vector3 pos;
    public Quaternion rot;
    
    void Start()
    {
        Create_Amongus();
        Debug.Log($"{pre.name}�� �ڽ� ������Ʈ�� ��:{pre.transform.childCount}");

        Debug.Log($"{pre.name}�� ù��° �ڽ� ������Ʈ �̸�:{pre.transform.GetChild(0).name}");
        Debug.Log($"{pre.name}�� ������ �ڽ� ������Ʈ �̸�:{pre.transform.GetChild(pre.transform.childCount-1).name}");
    }
    void Create_Amongus(string n="����")//ĳ���� ���� �� �̸� ����
    {
        pre=Instantiate(pre, pos, rot);
        pre.name = "����";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(pre);
        }
    }
}
