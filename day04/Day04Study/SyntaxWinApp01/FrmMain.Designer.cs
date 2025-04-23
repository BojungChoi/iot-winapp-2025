namespace SyntaxWinApp01
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            TxtResult = new TextBox();
            TxtPhone = new MaskedTextBox();
            NudAge = new NumericUpDown();
            TxtGender = new TextBox();
            TxtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            BtnCheck = new Button();
            PicResult = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(NudAge);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "정보입력/결과";
            // 
            // TxtResult
            // 
            TxtResult.BorderStyle = BorderStyle.FixedSingle;
            TxtResult.Font = new Font("한컴 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            TxtResult.Location = new Point(7, 184);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(275, 100);
            TxtResult.TabIndex = 5;
            TxtResult.TextChanged += TxtResult_TextChanged;
            // 
            // TxtPhone
            // 
            TxtPhone.BorderStyle = BorderStyle.FixedSingle;
            TxtPhone.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold);
            TxtPhone.Location = new Point(77, 132);
            TxtPhone.Mask = "000-9000-0000";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(127, 25);
            TxtPhone.TabIndex = 4;
            TxtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // NudAge
            // 
            NudAge.BorderStyle = BorderStyle.FixedSingle;
            NudAge.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold);
            NudAge.Location = new Point(77, 63);
            NudAge.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            NudAge.Name = "NudAge";
            NudAge.Size = new Size(127, 25);
            NudAge.TabIndex = 2;
            NudAge.TextAlign = HorizontalAlignment.Center;
            NudAge.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // TxtGender
            // 
            TxtGender.AccessibleDescription = "";
            TxtGender.BorderStyle = BorderStyle.FixedSingle;
            TxtGender.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold);
            TxtGender.Location = new Point(77, 97);
            TxtGender.MaxLength = 1;
            TxtGender.Name = "TxtGender";
            TxtGender.PlaceholderText = "M또는F만 삽입";
            TxtGender.Size = new Size(127, 25);
            TxtGender.TabIndex = 3;
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.FixedSingle;
            TxtName.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold);
            TxtName.Location = new Point(77, 26);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(127, 25);
            TxtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("한컴 고딕", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(18, 64);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "나이 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("한컴 고딕", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(18, 99);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 0;
            label3.Text = "성별 : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("한컴 고딕", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(4, 160);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 0;
            label5.Text = "결 과";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.Font = new Font("한컴 고딕", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(18, 134);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 0;
            label4.Text = "폰번호 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("한컴 고딕", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "이름 :";
            // 
            // BtnCheck
            // 
            BtnCheck.Font = new Font("한컴 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnCheck.Location = new Point(497, 273);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(75, 23);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "체 크";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // PicResult
            // 
            PicResult.BackColor = Color.Transparent;
            PicResult.Location = new Point(322, 20);
            PicResult.Name = "PicResult";
            PicResult.Size = new Size(250, 250);
            PicResult.TabIndex = 2;
            PicResult.TabStop = false;
            PicResult.Click += PicResult_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(584, 311);
            Controls.Add(PicResult);
            Controls.Add(BtnCheck);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법 학습 윈앱01";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown NudAge;
        private TextBox TxtName;
        private Label label2;
        private Label label1;
        private Button BtnCheck;
        private MaskedTextBox TxtPhone;
        private TextBox TxtGender;
        private Label label3;
        private Label label4;
        private PictureBox PicResult;
        private TextBox TxtResult;
        private Label label5;
    }
}
