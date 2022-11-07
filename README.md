# CS_Server_Framework
C# 비동기 서버 프레임워크

# 환경 설정
- <img src="https://img.shields.io/badge/Visual Studio 2022-5C2D91?style=flat&logo=Visual Studio&logoColor=white"/>    
- <img src="https://img.shields.io/badge/C%23-00599C?style=flat&logo=Csharp&logoColor=white"/>

# 코드 설명   
## ServerCore   
- Engine 부분으로서 Client, Server Core 부분이며 Client, Server 통신 관련
- Conntector.cs : 소켓 객체 생성(TCP 소켓), 포트 바인딩을 하며 Connect 관련 정의
- Listener.cs : 포트 Listening 시작하며 연결을 받아들이면서 소켓 생성(SocketAsync 사용)
## - Server   
## - Dummy   
