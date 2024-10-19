using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //자식 오브젝트의 트랜스폼을 담을 배열 변수 선언
    public Transform[] spawnPoint;

    float timer;

    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime; //한 프레임이 소비한 시간

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
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //spawn오브젝트는 제외하도록 1부터시작
    }
}
