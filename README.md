# 유니티 공부

## 1_게임 오브젝트 흐름

- 초기화 영역 : 게임이 시작될 때 실행되는 영역

    `void Awake()`

    `void Start()`

- 게임 오브젝트 활성화: Awake와 Start 사이에 들어감

    `void OnEnable()`
 
- 물리 영역: 물리적 계산이 필요한 코드 작성
 
    `void FixedUpdate()`
 
- 게임 로직 영역: 주기적으로 업데이트 되는 영역
 
    `void Update()`

- 모든 업데이트 끝난 후

    `void LateUpdate()`

- 게임 오브젝트 비활성화

    `void OnDisable()`

- 해체 영역

    `void OnDestroy()`
