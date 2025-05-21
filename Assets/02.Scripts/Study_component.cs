using UnityEngine;

public class Study_component : MonoBehaviour
{
    public GameObject obj_study;
    public string chage_name="test";
    void Start()
    {
        obj_study = GameObject.Find("Cube");
        obj_study.name = chage_name;   
    }

    // Update is called once per frame
}
