using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    Rigidbody2D rigid;
    public float speed;


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    //물리 연산 프레임마다 호출되는 생명주기 함수
    void FixedUpdate()
    {
        Vector2 nextVector = inputVec * speed * Time.fixedDeltaTime;
        // 위치 이동
        rigid.MovePosition(rigid.position + nextVector); // MovePosition은 월드좌표기준이라 현재좌표값을 더해줌
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
