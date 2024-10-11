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
        inputVec.x = Input.GetAxis("Horizontal"); //project에서 수평 설정된 이름
        inputVec.y = Input.GetAxis("Vertical"); //project에서 수직 설정된 이름
    }
}
