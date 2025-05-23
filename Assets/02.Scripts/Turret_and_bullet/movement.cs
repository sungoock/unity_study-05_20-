//using UnityEngine;

//public class movement : MonoBehaviour
//{
//    public float move_speed = 0.1f;
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKey(KeyCode.W))
//        {
//            transform.position += Vector3.forward * move_speed * Time.deltaTime;
//        }
//        if (Input.GetKey(KeyCode.S))
//        {
//            transform.position += Vector3.back * move_speed * Time.deltaTime;
//        }

//        if (Input.GetKey(KeyCode.A))
//        {
//            transform.position += Vector3.left * move_speed * Time.deltaTime;
//        }

//        if (Input.GetKey(KeyCode.D))
//        {
//            transform.position += Vector3.right * move_speed * Time.deltaTime;
//        }


//    }
//}
using UnityEngine;
 
 public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {

        float h = Input.GetAxisRaw("Horizontal");//x�� �̵� 
        float v = Input.GetAxisRaw("Vertical");//y�� �̵�
        //raw�� ���� ��� ���� �ϸ� �̵�
        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normal_dir= dir.normalized;// ����ȭ(���� �ִ밪 1�� ����)
        Debug.Log($"���� �Է� : {dir}");

        transform.position += normal_dir * moveSpeed * Time.deltaTime;
        transform.LookAt(transform.position+normal_dir);//�̵� ������ �ٶ󺸴� ���
        
    }
}