namespace SyntaxWinApp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("값을 채워주세요.");
                return; // 메서드 탈출
            }
            else
            {
                LblResult.Text = "처리결과 : ";
                TxtResult.Text = "ㅋㅋ 진짜 채워넣냐";
                // 위의 문제가 없을때 동작...
            }
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
