namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // �⺻ ������
            Person BJ = new Person();
            BJ.Name = TxtName.Text.Trim();
            BJ.Age = int.Parse(TxtAge.Text.Trim());
            BJ.Gender = char.Parse(TxtGender.Text.Trim());
            BJ.Phone = TxtPhone.Text.Trim();

            
            // �Ű����� ������
            Person Ho = new Person("�Ƿ���", 10, 'F', "010-2222-4141");


            TxtResult.Text += BJ.ToString();
            BJ.GetUp();
            BJ.GoToSchool();

            //BJ.GetNumber();
            // static�� ���� ��ü�� �������� ����.
            Person.GetNumber();

        }

        // static : ������ �� ������ڸ��� �޸𸮿� �ڸ��� ����


    }
}
