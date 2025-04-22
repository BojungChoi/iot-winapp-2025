using Microsoft.VisualBasic.Devices;
using SyntaxWinApp02.Properties;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Computer Mycomputer = new Computer();
            //NoteBook myNotebook = new NoteBook();
            //Server yourServer = new Server();

            //Computer yourCom = new NoteBook(); // 부모클래스의 객체를 자식클래스에 대입
            //NoteBook notebook = new Computer(); // 이건 불가능 
            switch (CboDivision.SelectedIndex)
            {
                case 0: // Computer
                    Computer myCom = new Computer();
                    PicComputer.Image = Resources.computer_case;

                    myCom.Reset();
                    myCom.Shutdown();
                    myCom.Boot();
                    break;
                case 1: // NoteBook
                    NoteBook myBook = new NoteBook();
                    PicComputer.Image = Resources.laptop;

                    myBook.Reset();
                    myBook.Shutdown();  // 부모와 다르게 동작

                    //Computer sCom = myBook;
                    // 부모 클래스를 자식클래스로 형변환하면서 문재발생 소지
                    //NoteBook myBook2 = (NoteBook)new Computer();
                    Computer myComputer = new NoteBook();

                    if (myComputer is NoteBook)
                    {
                        Console.WriteLine("myComputer는 Notebook입니다.");
                        NoteBook myBook2 = myComputer as NoteBook;
                        Console.WriteLine("myComputer를 Notebook으로 변경!");
                    }

                    // 지문인식확인
                    bool hasFinger = myBook.HasFingerScanDevice();
                    Console.WriteLine($"최초 지문인식여부 :: {hasFinger}");

                    hasFinger = myBook.HasFingerScanDevice(true);
                    Console.WriteLine($"최종 지문인식여부 :: {hasFinger}");
                    break;

                case 2: // Server
                    Server yourSev = new Server();
                    PicComputer.Image = Resources.server;
                    break;
                default:
                    break;
            }

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP서버";

            Server server2 = server1;   // 얕은 복사 : 같은 내용 참조
            server2.Name = "DELL서버";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);
            MessageBox.Show($"서버1의 이름 : {server1.Name} \n서버2의 이름 : {server2.Name}");

            // 깊은 복사 : 완전 다른 객체로 복사
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL서버";
            
            isSame = server1.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"서버1의 이름 : {server1.Name} \n서버3의 이름 : {server3.Name}");
        }
    }
}
