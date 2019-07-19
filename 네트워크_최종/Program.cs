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

            //Udp 소켓 생성 - 14000번 포트

            //멀티캐스트 그룹 가입 - 255.0.7.19

            //서브스레드 생성 - 매개변수로 Udp 소켓 전달

            //무한반복
            while (true) //for(; ;)
            {

            }
            //사용자 입력
            //byte[]로 변환 및 멀티캐스트 그룹에 송신

            //Udp소켓 종료
        }
        //데이터 수신을 받기 위한 서브스레드 생성을 함수 정의
        //socket : UdpClient 객체                             두가지 소켓을 쓰면 스레드가 종료를 할때 서브 스레드는 종료를 하지 못한다?
        static void recv_thread(object socket)
        {
            //object UdpClient 객체로 변환
            //byte[], string, BinartFormaater, MemoryStream 선언
            //무한 반복 - 스레드 종료 메세지가 들어오면 종료
                //데이터 수신
                //byte[] -> string 변환 및 화면출력
        }
    }
}
