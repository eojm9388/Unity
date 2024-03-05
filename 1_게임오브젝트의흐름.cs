using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 초기화 영역
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");     
    }
    // 게임 오브젝트 활성화
    void OnEnable()
    {
        Debug.Log("로그인");
    }
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");     
    }

    // 물리 영역 - 물리적 계산이 필요한 코드 작성
    void FixedUpdate()
    {
        // 1초에 50번 정도 실행
        Debug.Log("이동~");
    }

    // 게임 로직 영역 - 주기적으로 업데이트 되는 영역
    void Update()
    {
        // 60 프레임으로 실행
        Debug.Log("몬스터 사냥!");
    }

    // 모든 업데이트 끝난 후
    void LateUpdate()
    {
        Debug.Log("경험치 획득!");
    }

    // 게임 오브젝트 비활성화
    void OnDisable()
    {
        Debug.Log("로그아웃");
    }


    // 해체 영역
    void OnDestroy()
    {
        Debug.Log("플레이어가 해체되었습니다.");
    }
}
