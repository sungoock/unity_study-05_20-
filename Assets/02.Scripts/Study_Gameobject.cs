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
        Debug.Log($"{pre.name}의 자식 오브젝트의 수:{pre.transform.childCount}");

        Debug.Log($"{pre.name}의 첫번째 자식 오브젝트 이름:{pre.transform.GetChild(0).name}");
        Debug.Log($"{pre.name}의 마지막 자식 오브젝트 이름:{pre.transform.GetChild(pre.transform.childCount-1).name}");
    }
    void Create_Amongus(string n="어몽어스")//캐릭터 생성 및 이름 변경
    {
        pre=Instantiate(pre, pos, rot);
        pre.name = "어몽어스";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(pre);
        }
    }
}
