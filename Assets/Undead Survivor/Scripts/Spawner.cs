using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //자식 오브젝트의 트랜스폼을 담을 배열 변수 선언
    public Transform[] spawnPoint;
    public SpawnData[] spawnData;
    int level;
    float timer;

    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime; //한 프레임이 소비한 시간
        level = Mathf.FloorToInt(GameManager.instance.gameTime / 10f);


        if(timer > (level == 0 ? 0.5f : 0.2f))
        {
            timer = 0;
            Spawn();
        }
    }


    void Spawn()
    {
       GameObject enemy =  GameManager.instance.pool.Get(level);
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position; //spawn오브젝트는 제외하도록 1부터시작
    }
}


[System.Serializable] 
public class SpawnData
{
    public int spriteType;
    public float spawnTime;
    public int health;
    public float speed;
}
