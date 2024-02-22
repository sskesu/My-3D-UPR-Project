# My-3D-UPR-Project

최철환(내배캠_Unity_3기_3조)

심화 주차 강의 실습 베이스로 RPG나 소울류 느낌이 나도록 기능 추가

플레이어 공격 적용 추가
플레이어 UI(체력바만 사용), 적 UI 추가
적 랜덤(정해둔 위치들 중) 위치 생성
조건(적 죽고 2초 후)에 따라 적 스폰
아이템 사용(시간이 없어서 포션만, 추가한다면 좀 더 확장성을 고려한 코드로 수정 필요)
 
플레이어, 적 공통 데미지 입었을 때 HPBar 업데이트 부분 코드 정리

데미지를 입었을 때 작동하는 것 같음, 작동하는 함수 위치 다름 -> 이벤트로 연결하기

플레이어만 적용되는 부분을 적도 적용되게, 코드도 깔끔해짐

플레이어 HP는 UIManager에서 관리
적은 EnemyUI에서 각각 이벤트를 연결해줌

적 HPBar가 움직임에 따라 회전하는 문제

![image](https://github.com/sskesu/My-3D-UPR-Project/assets/136444697/68f3cee7-905a-43ce-a039-4eef343d849e)

HPBar의 Rotation 값을 메인 카메라와 같게 해줌

![image](https://github.com/sskesu/My-3D-UPR-Project/assets/136444697/46da8bdc-5368-4ac0-aa54-0933e8191937)

적 HP 가 0이 되면(죽으면) HPBar 사라지도록 수정

![image](https://github.com/sskesu/My-3D-UPR-Project/assets/136444697/46a849e8-b52e-4ec7-b594-befb549631d2)

적 랜덤 장소 생성, 적 처치 시 재생성 

![image](https://github.com/sskesu/My-3D-UPR-Project/assets/136444697/98968320-004f-4285-9e73-95ac9ab21bc2)

죽은 적 파괴하거나 재사용 하지 않는 이유 : 시체가 증발하지 않는 것이 기획적으로 맞는 것 같고 시체에서 아이템 파밍(추후 추가)을 하기 위해서

![image](https://github.com/sskesu/My-3D-UPR-Project/assets/136444697/532395c9-707a-47d2-8009-6047737c7b25)

R 키 입력 받아 포션 사용

![image](https://github.com/sskesu/My-3D-UPR-Project/assets/136444697/236fcef2-bc8d-4d6d-9ac9-e53f7397f55f)

수량이 0개 이하일 때 사용 x

