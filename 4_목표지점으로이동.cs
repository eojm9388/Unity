using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    // Vector3 velocity = Vector3.zero; -> Update 영역 밖에 써줄 때 속도가 더 빠름 
    void Update()
    {   // 1. 일정한 속도로 이동
        // Vector3.MoveTowards(현재 위치, 목표 위치, 속도)
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 0.1f);
        */
        // 2. 부드러운 감속 이동
        // Vector3.SmoothDamp(현재 위치, 목표 위치, 참조 속도, 속도);

        /*        
        Vector3 velocity = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velocity, 1f);
        */
        /*
         3. 선형 보간: SmoothDamp 보다 감속시간이 김
            Vector3.Lerp(현재 위치, 목표 위치, 속도) 
        
        transform.position =
            Vector3.Lerp(transform.position, target, 0.001f);
        */
        /* 4. 구면 선형 보간: 호를 그리며 이동
            Vector3.Slerp.(현재 위치, 목표 위치, 속도)
            
        */
        transform.position = Vector3.Slerp(
            transform.position, target, 0.01f
            );

    }
}
