using System.Text;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        private string filePath = "sample.rtf"; // Rich Text Format(msWord 유사)
        public FrmMain()
        {
            InitializeComponent();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; // 파일 저장
            // 3. SaveFileDialog 사용 
            DlgSave.FileName = string.Empty; // 초기화
            DlgSave.Filter = "RTF파일 (*.rtf)|*.rtf|Txt파일 (*.txt)|*.txt";
            DlgSave.Title = "문서파일 저장";

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
                    //File.WriteAllText(fullPath, RtbNote.Text, Encoding.UTF8); //  인코딩 설정

                    MessageBox.Show("파일이 저장되었습니다.", "파일저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"저장 실패 : {ex.Message}", "파일저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //try
            //{
            //    // 1.일반 Txt 파일로 저장
            //    //File.WriteAllText(filePath, RtbNote.Text);

            //    // 2.Rich Text Format으로 저장
            //    RtbNote.SaveFile(filePath, RichTextBoxStreamType.RichText);

            //    MessageBox.Show("파일이 저장되었습니다.", "파일저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"저장 실패 : {ex.Message}", "파일저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    throw;
            //}

        }
        private void RtbNote_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; // 파일 불러오기
            // 3. OpenFileDialog 사용 // doc, docx는 실제 로드 불가
            DlgOpen.FileName = ""; // 초기화
            DlgOpen.Filter = "RTF파일 (*.rtf)|*.rtf|Txt파일 (*.txt)|*.txt";
            DlgOpen.Title = "RTF파일 읽기";

            // 다이얼로그창에 열기(DialogResult.OK), 취소 (DialogResult.Cancel) 버튼이 있음  
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
                    MessageBox.Show("파일이 불러와졌습니다.", "파일불러오기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"불러오기 실패 : {ex.Message}", "파일불러오기", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            //try
            //{
            //    if (File.Exists(filePath))
            //    {

            //        // 1.일반 Txt 파일로 불러오기
            //        //string content = File.ReadAllText(filePath);

            //        // 2.Rich Text Format으로 불러오기
            //        RtbNote.LoadFile(filePath, RichTextBoxStreamType.RichText);

            //        MessageBox.Show("파일이 불러와졌습니다.", "파일불러오기", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show($"파일이 존재하지 않습니다.", "파일불러오기", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"불러오기 실패 : {ex.Message}", "파일불러오기", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            //RtbNote.SelectionColor = Color.Red;
            if (RtbNote.SelectionLength > 0)
            {
                if (DlgColor.ShowDialog() == DialogResult.OK)
                {
                    RtbNote.SelectionColor = DlgColor.Color; // 선택된 글자 색상 변경
                }
            }
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font currFont = RtbNote.SelectionFont;
            FontStyle newStyle;

            if (currFont.Bold)
            {
                newStyle = currFont.Style & ~FontStyle.Bold; // Bold 제거
            }
            else
            {
                newStyle = currFont.Style | FontStyle.Bold; // Bold 추가
            }

            RtbNote.SelectionFont = new Font(currFont, newStyle);
        }

        private void DlgOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
