using System.Text;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        private string filePath = "sample.rtf"; // Rich Text Format(msWord ����)
        public FrmMain()
        {
            InitializeComponent();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; // ���� ����
            // 3. SaveFileDialog ��� 
            DlgSave.FileName = string.Empty; // �ʱ�ȭ
            DlgSave.Filter = "RTF���� (*.rtf)|*.rtf|Txt���� (*.txt)|*.txt";
            DlgSave.Title = "�������� ����";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgSave.FileName;
                    string ext = Path.GetExtension(fullPath); // .rtf, .txt

                    if (ext == ".rtf")
                        RtbNote.SaveFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.SaveFile(fullPath, RichTextBoxStreamType.PlainText);
                    //File.WriteAllText(fullPath, RtbNote.Text, Encoding.UTF8); //  ���ڵ� ����

                    MessageBox.Show("������ ����Ǿ����ϴ�.", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"���� ���� : {ex.Message}", "��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //try
            //{
            //    // 1.�Ϲ� Txt ���Ϸ� ����
            //    //File.WriteAllText(filePath, RtbNote.Text);

            //    // 2.Rich Text Format���� ����
            //    RtbNote.SaveFile(filePath, RichTextBoxStreamType.RichText);

            //    MessageBox.Show("������ ����Ǿ����ϴ�.", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"���� ���� : {ex.Message}", "��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    throw;
            //}

        }
        private void RtbNote_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; // ���� �ҷ�����
            // 3. OpenFileDialog ��� // doc, docx�� ���� �ε� �Ұ�
            DlgOpen.FileName = ""; // �ʱ�ȭ
            DlgOpen.Filter = "RTF���� (*.rtf)|*.rtf|Txt���� (*.txt)|*.txt";
            DlgOpen.Title = "RTF���� �б�";

            // ���̾�α�â�� ����(DialogResult.OK), ��� (DialogResult.Cancel) ��ư�� ����  
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgOpen.FileName;
                    string ext = Path.GetExtension(fullPath); // .rtf, .txt

                    if (ext == ".rtf")
                    RtbNote.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("������ �ҷ��������ϴ�.", "���Ϻҷ�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�ҷ����� ���� : {ex.Message}", "���Ϻҷ�����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            //try
            //{
            //    if (File.Exists(filePath))
            //    {

            //        // 1.�Ϲ� Txt ���Ϸ� �ҷ�����
            //        //string content = File.ReadAllText(filePath);

            //        // 2.Rich Text Format���� �ҷ�����
            //        RtbNote.LoadFile(filePath, RichTextBoxStreamType.RichText);

            //        MessageBox.Show("������ �ҷ��������ϴ�.", "���Ϻҷ�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show($"������ �������� �ʽ��ϴ�.", "���Ϻҷ�����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"�ҷ����� ���� : {ex.Message}", "���Ϻҷ�����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            //RtbNote.SelectionColor = Color.Red;
            if (RtbNote.SelectionLength > 0)
            {
                if (DlgColor.ShowDialog() == DialogResult.OK)
                {
                    RtbNote.SelectionColor = DlgColor.Color; // ���õ� ���� ���� ����
                }
            }
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font currFont = RtbNote.SelectionFont;
            FontStyle newStyle;

            if (currFont.Bold)
            {
                newStyle = currFont.Style & ~FontStyle.Bold; // Bold ����
            }
            else
            {
                newStyle = currFont.Style | FontStyle.Bold; // Bold �߰�
            }

            RtbNote.SelectionFont = new Font(currFont, newStyle);
        }

        private void DlgOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
