namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void BrtMsg_Click(object sender, EventArgs e)
        {
            // 분기문
            if (TexPain.Text == "아니오")
            {
                MessageBox.Show("병원을 왜왔어요. 집에가");
            }
            else if (TexPain.Text == "네")
            {
                string PainPoint = CbopainPoint.SelectedItem.ToString();

                switch (PainPoint)
                {
                    /* 머리 눈 코 귀 목 어깨 팔 손 허리 다리 발 */
                    case "머리":
                    case "목":
                        MessageBox.Show("신경과로 갑니다", "진료과 선택");
                        break;
                    case "어깨":
                    case "허리":
                    case "골반":
                        MessageBox.Show("정형외과 갑니다.", "진료과 선택");
                        break;
                    case "가슴":
                    case "등":
                        MessageBox.Show("CT 찍으러갑니다", "진료과 선택");
                        break;
                }
            }
            else
            {
                MessageBox.Show("아니오, 네 중 하나를 선택하세요");
            }
        }
        private void TexPain_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스에서 선택된 값을 메시지박스에 출력
            var selectedPoint = CbopainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "선택값", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TexPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 키프레스에서 엔터를 입력하면 C, C++ if문과 동일
            if (e.KeyChar == (char)Keys.Enter)
            {
                // 텍스트박스에 입력된 값을 메시지박스에 출력
                MessageBox.Show(TexPain.Text, "입력값", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            // for 문
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    var result = x + "x" + y + "=" + (x * y);
                    TxtDisplay.Text += result + " ";
                }
                TxtDisplay.Text += "\r\n";  // 원래 윈도우는 \r\n을 같이 써야 함
            }
        }


        

        private void BtnWhile_Click(object sender, EventArgs e)
        {
        int clickNum = 0;
            /// 무한 반복
            while (true)
            {
                MessageBox.Show("계속 > " + clickNum);
                clickNum++;
                    if (clickNum ==10)
                {
                    break; // 반복문 탈출
                    // continue; 도 파악할 것
                }
            }
        }
    }
}
