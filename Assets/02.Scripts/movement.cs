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
        /// Input System (Old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 화살표키보드
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}