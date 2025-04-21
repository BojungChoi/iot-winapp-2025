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
            // �б⹮
            if (TexPain.Text == "�ƴϿ�")
            {
                MessageBox.Show("������ �ֿԾ��. ������");
            }
            else if (TexPain.Text == "��")
            {
                string PainPoint = CbopainPoint.SelectedItem.ToString();

                switch (PainPoint)
                {
                    /* �Ӹ� �� �� �� �� ��� �� �� �㸮 �ٸ� �� */
                    case "�Ӹ�":
                    case "��":
                        MessageBox.Show("�Ű���� ���ϴ�", "����� ����");
                        break;
                    case "���":
                    case "�㸮":
                    case "���":
                        MessageBox.Show("�����ܰ� ���ϴ�.", "����� ����");
                        break;
                    case "����":
                    case "��":
                        MessageBox.Show("CT ���������ϴ�", "����� ����");
                        break;
                }
            }
            else
            {
                MessageBox.Show("�ƴϿ�, �� �� �ϳ��� �����ϼ���");
            }
        }
        private void TexPain_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �޺��ڽ����� ���õ� ���� �޽����ڽ��� ���
            var selectedPoint = CbopainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "���ð�", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TexPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ű���������� ���͸� �Է��ϸ� C, C++ if���� ����
            if (e.KeyChar == (char)Keys.Enter)
            {
                // �ؽ�Ʈ�ڽ��� �Էµ� ���� �޽����ڽ��� ���
                MessageBox.Show(TexPain.Text, "�Է°�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            // for ��
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    var result = x + "x" + y + "=" + (x * y);
                    TxtDisplay.Text += result + " ";
                }
                TxtDisplay.Text += "\r\n";  // ���� ������� \r\n�� ���� ��� ��
            }
        }


        

        private void BtnWhile_Click(object sender, EventArgs e)
        {
        int clickNum = 0;
            /// ���� �ݺ�
            while (true)
            {
                MessageBox.Show("��� > " + clickNum);
                clickNum++;
                    if (clickNum ==10)
                {
                    break; // �ݺ��� Ż��
                    // continue; �� �ľ��� ��
                }
            }
        }
    }
}
