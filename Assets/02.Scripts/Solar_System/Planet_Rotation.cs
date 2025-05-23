using UnityEngine;

public class Planet_Rotation : MonoBehaviour
{
    public Transform target_Planet;
    public float rol_speed ;//���� �ӵ�
    public float rev_speed ;//���� �ӵ�
    public bool is_revolution;
    void Update()
    {
        transform.Rotate(transform.up * rol_speed * Time.deltaTime);
        if (is_revolution)
        {
            transform.RotateAround(target_Planet.position, Vector3.up, rev_speed * Time.deltaTime);
        }

    }
}
