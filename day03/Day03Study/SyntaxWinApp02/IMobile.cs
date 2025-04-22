using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp02
{
    // 인터페이스는 다중상속이 가능
    // 인터페이스를 구현(상속의 일종) 하는 클래스에서 메서드 재정의
    // 인터페이스를 구현하는 클래스는 반드시 인터페이스에 정의된 모든 메서드를 구현해야 함
    interface IMobile
    {
        void call(); // 구현이 없음
        string GetList();

    }
}
