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

            //Computer yourCom = new NoteBook(); // �θ�Ŭ������ ��ü�� �ڽ�Ŭ������ ����
            //NoteBook notebook = new Computer(); // �̰� �Ұ��� 
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
                    myBook.Shutdown();  // �θ�� �ٸ��� ����

                    //Computer sCom = myBook;
                    // �θ� Ŭ������ �ڽ�Ŭ������ ����ȯ�ϸ鼭 ����߻� ����
                    //NoteBook myBook2 = (NoteBook)new Computer();
                    Computer myComputer = new NoteBook();

                    if (myComputer is NoteBook)
                    {
                        Console.WriteLine("myComputer�� Notebook�Դϴ�.");
                        NoteBook myBook2 = myComputer as NoteBook;
                        Console.WriteLine("myComputer�� Notebook���� ����!");
                    }

                    // �����ν�Ȯ��
                    bool hasFinger = myBook.HasFingerScanDevice();
                    Console.WriteLine($"���� �����νĿ��� :: {hasFinger}");

                    hasFinger = myBook.HasFingerScanDevice(true);
                    Console.WriteLine($"���� �����νĿ��� :: {hasFinger}");
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
            server1.Name = "HP����";

            Server server2 = server1;   // ���� ���� : ���� ���� ����
            server2.Name = "DELL����";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);
            MessageBox.Show($"����1�� �̸� : {server1.Name} \n����2�� �̸� : {server2.Name}");

            // ���� ���� : ���� �ٸ� ��ü�� ����
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL����";
            
            isSame = server1.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"����1�� �̸� : {server1.Name} \n����3�� �̸� : {server3.Name}");
        }
    }
}
