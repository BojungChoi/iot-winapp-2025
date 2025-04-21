namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // 연산자 : =, +, -, *, /, %, ++, --, +=, -=, *=, /=, %=, ==, !=, >, <, >=, <=
            // &&
            // C, C++ 와 동일
            int val = 2 ^ 10;

            int result = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;

            MessageBox.Show(result.ToString(), "메시지 박스", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
