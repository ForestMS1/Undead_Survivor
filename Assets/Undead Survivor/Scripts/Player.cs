using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxis("Horizontal"); //project���� ���� ������ �̸�
        inputVec.y = Input.GetAxis("Vertical"); //project���� ���� ������ �̸�
    }
}
