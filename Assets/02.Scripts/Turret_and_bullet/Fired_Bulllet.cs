using UnityEngine;

public class Fired_Bulllet : MonoBehaviour
{
    public float bulletSpeed = 100f;
    private void Start()
    {
        Destroy(gameObject,3f);
    }
    void Update()
    {
        transform.position += gameObject.transform.forward * bulletSpeed * Time.deltaTime;
    }
}
