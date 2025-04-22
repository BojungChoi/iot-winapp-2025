// using ... 네임스페이스 추가
// C,C++ #include/ Python import ...과 유사
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp02
{
    internal class MobileDevice
    {
        public MobileDevice() { }
    }

    internal class Computer
    {
        //sealed Computer() { } // selaed는 상속을 막는 키워드 더이상 자식클래스를 만들고 싶지 않을때 사용
        public Computer() {
            Debug.WriteLine("Computer 객체생성 - 디버그");
            Console.WriteLine("Computer 객체생성 - 그냥실행");
        }

        bool powerOn;
        public void Boot() {
            Console.WriteLine("컴퓨터 부팅!");
        }
        public virtual void Shutdown() { 
            Console.WriteLine("컴퓨터 셧다운!");
        }
        public void Reset() { }
    }

    // C++ 에서는 다중상속이 가능하지만 C#에서는 불가능(JAVA도 마찬가지)
    internal class NoteBook : Computer, IMobile // <-- 인터페이스 구현
    {

        public void call()
        {
            Console.WriteLine("노트북으로 전화걸기!");
        }

        public string GetList()
        {
            string phoneList = "010-1234-5678, 010-9876-5432";
            return phoneList;
        }


        public NoteBook()
        {
            Console.WriteLine("NoteBook객체 생성");
            base.Boot(); // 부모클래스의 Boot() 메서드 호출
        }
        // 부모클래스 Shutdown() 메서드 오버라이딩(자식에서 재정의)
        public override void Shutdown()
        {
            Console.WriteLine("---------------노트북 닫기!--------------");
        }

        bool fingerScan; // 지문인식

        // 파라미터가 없는 메서드
        public bool HasFingerScanDevice() { return this.fingerScan; }

        // 파라미터가 있는 메서드
        public bool HasFingerScanDevice(bool fingerScan)
        {
            this.fingerScan = fingerScan;
            Console.WriteLine("오버로딩때매 bool 타입 자료형으로된 메소드로 들어왔다리~");
            return this.fingerScan;
        }

    }

    internal class  Server : Computer
    {
        public string Name { get; set; } // 이름 속성(Property) 추가

        public Server() { Console.WriteLine("Server 객체 생성"); }

        bool storage; // 스토리지

        public bool HasStorage() { return this.storage; }

        public Server DeepCopy()
        {

            Console.WriteLine("-------------------------------------------------\nServer 깊은복사 호출!");
            return new Server { Name = this.Name };
        }
    }
}
