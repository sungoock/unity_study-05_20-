using UnityEngine;

public class Study_Destroy : MonoBehaviour
{
    public float delay_time;
    void Start()
    {
        Destroy(this,delay_time );
    }
    private void OnDestroy()
    {
        Debug.Log($"{name} �ı���");
    }
    // Update is called once per frame
}
