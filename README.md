# CS_Server_Framework
C# 비동기 서버 프레임워크

# 환경 설정
- <img src="https://img.shields.io/badge/Visual Studio 2022-5C2D91?style=flat&logo=Visual Studio&logoColor=white"/>    
- <img src="https://img.shields.io/badge/C%23-00599C?style=flat&logo=Csharp&logoColor=white"/>

# 코드 설명   
- ServerCore를 Class Lib화하여 각 클라이언트와 서버에서 사용
## ServerCore(Lib)   
- Engine 부분으로서 Client, Server Core 부분이며 Client, Server 통신 관련
- Conntector.cs : 소켓 객체 생성(TCP 소켓), 포트 바인딩을 하며 Connect 관련 정의
- Listener.cs : 포트 Listening 시작하며 연결을 받아들이면서 소켓 생성(SocketAsync 사용)
- RecvBuffer.cs : 소켓 비동기 Recv를 위한 RecvBuffer
- SendBuffer.cs : 소켓 비동기 Send를 위한 SendBuffer 
- Session.cs : Send, Recv 등 소켓 Session
- JobQueue.cs : 주고 받는 패킷 작업을 위한 Queue
- PriorityQueue.cs : 우선순위 Queue
## - Server   
## - Dummy   
