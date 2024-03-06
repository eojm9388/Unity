using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {   /*
        // 오브젝트는 변수 transform을 항상 가지고 있다
        Vector3 vec = new Vector3(5, 0, 0); // 벡터 값
        transform.Translate(vec);
        // int number = 4;  스칼라 값
        */
    }
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"), // X축 방향키 입력값을 받아 이동시킨다
            Input.GetAxisRaw("Vertical"),   // Y축 방향키 입력값을 받아 이동시킨다
            0); // 벡터 값
        transform.Translate(vec);

    }
}
