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
            TxtPhone = new TextBox();
            TxtGender = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtAge = new TextBox();
            label2 = new Label();
            TxtName = new TextBox();
            label1 = new Label();
            BtnCheck = new Button();
            TxtResult = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Cursor = Cursors.IBeam;
            groupBox1.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 337);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "사람 정보 입력";
            // 
            // TxtPhone
            // 
            TxtPhone.BorderStyle = BorderStyle.FixedSingle;
            TxtPhone.Location = new Point(112, 206);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(140, 28);
            TxtPhone.TabIndex = 3;
            // 
            // TxtGender
            // 
            TxtGender.BorderStyle = BorderStyle.FixedSingle;
            TxtGender.Location = new Point(112, 170);
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(140, 28);
            TxtGender.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold);
            label4.Location = new Point(25, 209);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 1;
            label4.Text = "전화번호  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 173);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 1;
            label3.Text = "성     별   : ";
            // 
            // TxtAge
            // 
            TxtAge.BorderStyle = BorderStyle.FixedSingle;
            TxtAge.Location = new Point(112, 134);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(140, 28);
            TxtAge.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 137);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "나     이   :";
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.FixedSingle;
            TxtName.Location = new Point(112, 97);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(140, 28);
            TxtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold);
            label1.Location = new Point(25, 100);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 1;
            label1.Text = "이     름   : ";
            // 
            // BtnCheck
            // 
            BtnCheck.Font = new Font("한컴 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnCheck.Location = new Point(472, 309);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 5;
            BtnCheck.Text = "확 인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // TxtResult
            // 
            TxtResult.BorderStyle = BorderStyle.FixedSingle;
            TxtResult.Location = new Point(319, 41);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(253, 262);
            TxtResult.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold);
            label6.Location = new Point(316, 16);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 1;
            label6.Text = "인 적 사 항";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(TxtResult);
            Controls.Add(BtnCheck);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "문법학습 윈앱1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnCheck;
        private TextBox TxtPhone;
        private TextBox TxtGender;
        private Label label4;
        private Label label3;
        private TextBox TxtAge;
        private Label label2;
        private TextBox TxtName;
        private Label label1;
        private TextBox TxtResult;
        private Label label6;
    }
}
