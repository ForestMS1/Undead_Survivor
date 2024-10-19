using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //�ڽ� ������Ʈ�� Ʈ�������� ���� �迭 ���� ����
    public Transform[] spawnPoint;

    float timer;

    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime; //�� �������� �Һ��� �ð�

        if(timer > 0.2f)
        {
            Spawn();
            timer = 0;
        }

        if(Input.GetButtonDown("Jump"))
        {
            GameManager.instance.pool.Get(1);
        }
    }


    void Spawn()
    {
       GameObject enemy =  GameManager.instance.pool.Get(Random.Range(0,2));
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //spawn������Ʈ�� �����ϵ��� 1���ͽ���
    }
}
