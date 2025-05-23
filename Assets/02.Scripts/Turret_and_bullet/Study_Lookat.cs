using UnityEngine;

public class Study_Lookat : MonoBehaviour
{
    public Transform target;
    public Transform turret_head;
    public GameObject bullet_pre;
    public Transform bullet_pos;

    public float fire_delay;
    public float timer;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        fire_delay = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        turret_head.LookAt(target);

        if (Input.GetMouseButton(0)&&timer>fire_delay)
        {
            Instantiate(bullet_pre, bullet_pos.position,bullet_pos.rotation);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
