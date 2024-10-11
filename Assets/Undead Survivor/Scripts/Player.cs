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
        inputVec.x = Input.GetAxisRaw("Horizontal"); //project���� ���� ������ �̸�
        inputVec.y = Input.GetAxisRaw("Vertical"); //project���� ���� ������ �̸�
    }

    //���� ���� �����Ӹ��� ȣ��Ǵ� �����ֱ� �Լ�
    void FixedUpdate()
    {
        //�밢�� �̵�(��Ʈ2)�� �����¿� �Ȱ���(1) �̵��ϵ��� normalized
        Vector2 nextVector = inputVec.normalized * speed * Time.fixedDeltaTime;
        // ��ġ �̵�
        rigid.MovePosition(rigid.position + nextVector); // MovePosition�� ������ǥ�����̶� ������ǥ���� ������
    }
}
