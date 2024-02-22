# My-3D-UPR-Project
 
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


![image](https://github.com/sskesu/My-3D-UPR-Project/assets/136444697/532395c9-707a-47d2-8009-6047737c7b25)

R 키 입력 받아 포션 사용

![image](https://github.com/sskesu/My-3D-UPR-Project/assets/136444697/236fcef2-bc8d-4d6d-9ac9-e53f7397f55f)

수량이 0개 이하일 때 사용 x

