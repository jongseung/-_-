using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 멀티캐스트 + 멀티쓰레드 기반의 채팅 프로그램 구현
* 기능)
* 메인스레드
* Udp 소켓 생성 및 특정 멀티캐스트 그룹 가입.
* 가입된 소켓을 서브스레드에게 넘겨줌
* 사용자입력을 받아 멀티캐스트 그룹에 송신
* 서브스레드
* 메인스레드가 준 Udp소켓을 바탕으로 수신되는 데이터를 출력
*/


namespace 네트워크_최종
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
