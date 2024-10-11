using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    Rigidbody2D rigid;
    public float speed;


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal"); //project에서 수평 설정된 이름
        inputVec.y = Input.GetAxisRaw("Vertical"); //project에서 수직 설정된 이름
    }

    //물리 연산 프레임마다 호출되는 생명주기 함수
    void FixedUpdate()
    {
        //대각선 이동(루트2)도 상하좌우 똑같게(1) 이동하도록 normalized
        Vector2 nextVector = inputVec.normalized * speed * Time.fixedDeltaTime;
        // 위치 이동
        rigid.MovePosition(rigid.position + nextVector); // MovePosition은 월드좌표기준이라 현재좌표값을 더해줌
    }
}
