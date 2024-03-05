using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 키보드 마우스 입력 받기
    void Update()
    {   // 키보드
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무키를 누름");
        /*if (Input.anyKey)
            Debug.Log("플레이어가 아무키를 누르고 있습니다");
        */
        /*
        if (Input.GetKeyDown(KeyCode.Return)) // Return -> 엔터키, Escape -> Esc키
            Debug.Log("아이템을 구입하였습니다");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽으로 이동을 멈췄습니다");
        */

        // 마우스 (0): 왼쪽버튼 (1): 오른쪽 버튼
        /*
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사");
        */

        /* Input Manager 
        - Horizontal: 횡 이동
        - Verticle: 종 이동
        - 기타 등등
        - size를 늘려 추가하고 싶은 버튼을 만들 수도 있음
         */
        /*
        if (Input.GetButtonDown("Jump")) // Jump -> Input Manager 버튼이름
            Debug.Log("점프");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!");
        */

        if (Input.GetButton("Horizontal")){
            Debug.Log("횡 이동중" 
                + Input.GetAxis("Horizontal")); // 가중치, GetAxisRaw: 일정값
        }
    }

}
