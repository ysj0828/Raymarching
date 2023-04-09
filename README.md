# 셰이더 공부 &amp; ray marching 기술 공부

Ray marching이란?

메시 데이터를 이용해 그리는 기존의 3D 렌더링 방식과는 달리 Signed Distance Function (SDF, 거리함수) 통해 오브젝트의 표면을 정의

카메라에서 스크린 픽셀을 향해 레이를 전진시키고, 해당 픽셀의 레이가 오브젝트 표면에 닿으면 그 픽셀에 오브젝트 표면을 렌더링

장점\
메시 데이터가 필요없으며 부드러운 표면이나 곡선 혹은 여러 오브젝트가 섞이는 듯한 연출이 가능\

단점\
연산이 매우 무겁다

## Ray marching 과 SDF을 활용한 렌더링 비교

유니티 기본 큐브 오브젝트에 색깔만 넣고 Raymarching을 사용하여 구체 모양으로 렌더 & 여러 큐브(구체)가 가까이 있으면 부드럽게 섞이는지 테스트

맥북 프로 M1 Max Ram 32GB 환경

![Screen Recording 2023-04-09 at 5 23 11 PM](https://user-images.githubusercontent.com/63217600/230762434-ccf71d7d-6ce3-4f7a-86f6-27f560da2cf1.gif)

갤럭시 노트 20 환경

<img src="https://user-images.githubusercontent.com/63217600/230762656-a63a9542-b4b2-4ae9-8f69-4ce5b5f5cc99.gif" width="50%" height="50%">

위에 보이는 것처럼 맥북에서는 60fps가 안정적으로 나오지만 모바일 환경에선 성능이 나쁘지 않은 기기임에도 15fps가 겨우 나오는 수준
