namespace SyntaxWinApp04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LblName = new Label();
            TxtName = new TextBox();
            LblAge = new Label();
            TxtAge = new TextBox();
            LblGender = new Label();
            RdoMale = new RadioButton();
            RdoFemale = new RadioButton();
            BtnMsg = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LblName.ForeColor = SystemColors.Control;
            LblName.Location = new Point(14, 15);
            LblName.Name = "LblName";
            LblName.Size = new Size(83, 21);
            LblName.TabIndex = 0;
            LblName.Text = "이름 입력 :";
            LblName.Click += LblName_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(99, 13);
            TxtName.Multiline = true;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(153, 23);
            TxtName.TabIndex = 1;
            TxtName.TextChanged += TxtName_TextChanged;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LblAge.ForeColor = SystemColors.Control;
            LblAge.Location = new Point(14, 51);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(83, 21);
            LblAge.TabIndex = 0;
            LblAge.Text = "나이 입력 :";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(99, 49);
            TxtAge.Multiline = true;
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(153, 23);
            TxtAge.TabIndex = 2;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LblGender.ForeColor = SystemColors.Control;
            LblGender.Location = new Point(14, 86);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(83, 21);
            LblGender.TabIndex = 0;
            LblGender.Text = "성별 입력 :";
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.BackColor = SystemColors.ControlLight;
            RdoMale.BackgroundImageLayout = ImageLayout.Zoom;
            RdoMale.Checked = true;
            RdoMale.Location = new Point(103, 87);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(49, 19);
            RdoMale.TabIndex = 3;
            RdoMale.TabStop = true;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = false;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.BackColor = SystemColors.ControlLight;
            RdoFemale.BackgroundImageLayout = ImageLayout.Zoom;
            RdoFemale.Location = new Point(158, 87);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(49, 19);
            RdoFemale.TabIndex = 4;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = false;
            // 
            // BtnMsg
            // 
            BtnMsg.Font = new Font("한컴 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnMsg.Location = new Point(499, 269);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(73, 34);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LblResult.ForeColor = SystemColors.Control;
            LblResult.Location = new Point(16, 127);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(81, 21);
            LblResult.TabIndex = 0;
            LblResult.Text = "결        과 :";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(101, 125);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(396, 138);
            TxtResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnMsg);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMale);
            Controls.Add(TxtResult);
            Controls.Add(TxtAge);
            Controls.Add(TxtName);
            Controls.Add(LblResult);
            Controls.Add(LblGender);
            Controls.Add(LblAge);
            Controls.Add(LblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "문법연습 윈앱04";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private TextBox TxtAge;
        private Label LblGender;
        private RadioButton RdoMale;
        private RadioButton RdoFemale;
        private Button BtnMsg;
        private Label LblResult;
        private TextBox TxtResult;
    }
}
