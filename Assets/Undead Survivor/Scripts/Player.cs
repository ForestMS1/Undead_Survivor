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
    SpriteRenderer spriter;


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }

    //���� ���� �����Ӹ��� ȣ��Ǵ� �����ֱ� �Լ�
    void FixedUpdate()
    {
        Vector2 nextVector = inputVec * speed * Time.fixedDeltaTime;
        // ��ġ �̵�
        rigid.MovePosition(rigid.position + nextVector); // MovePosition�� ������ǥ�����̶� ������ǥ���� ������
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

    //�������� ���� �Ǳ� �� ����Ǵ� �����ֱ� �Լ�
    void LateUpdate()
    {
        if(inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
    }
}
