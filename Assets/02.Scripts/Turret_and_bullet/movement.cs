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

        float h = Input.GetAxisRaw("Horizontal");//x축 이동 
        float v = Input.GetAxisRaw("Vertical");//y축 이동
        //raw가 없을 경우 가속 하며 이동
        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normal_dir= dir.normalized;// 정규화(방향 최대값 1로 고정)
        Debug.Log($"현재 입력 : {dir}");

        transform.position += normal_dir * moveSpeed * Time.deltaTime;
        transform.LookAt(transform.position+normal_dir);//이동 방향을 바라보는 기능
        
    }
}