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
            // 기본 생성자
            Person BJ = new Person();
            BJ.Name = TxtName.Text.Trim();
            BJ.Age = int.Parse(TxtAge.Text.Trim());
            BJ.Gender = char.Parse(TxtGender.Text.Trim());
            BJ.Phone = TxtPhone.Text.Trim();

            
            // 매개변수 생성자
            Person Ho = new Person("뽀룡이", 10, 'F', "010-2222-4141");


            TxtResult.Text += BJ.ToString();
            BJ.GetUp();
            BJ.GoToSchool();

            //BJ.GetNumber();
            // static일 경우는 객체를 생성하지 않음.
            Person.GetNumber();

        }

        // static : 컴파일 후 실행되자마자 메모리에 자리를 잡음


    }
}
