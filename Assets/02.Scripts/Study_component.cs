using UnityEngine;

public class Study_component : MonoBehaviour
{
    public GameObject obj;
    public Material mat;
    public Mesh mes;
    MeshRenderer meshRenderer;
    void Create_Cube(string name="Default") {
        obj = new GameObject(name);
        obj.AddComponent<MeshRenderer>();
        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.GetComponent<MeshFilter>().mesh = mes;
        obj.AddComponent<BoxCollider>();

    }
    void Start()
    {
        //Create_Cube("cube");
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // Update is called once per frame
}
