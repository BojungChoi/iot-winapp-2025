namespace WinFormsApp1
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
            LblCpu = new Label();
            TxtCpu = new TextBox();
            LblRam = new Label();
            TxtRam = new TextBox();
            BtnRefresh = new Button();
            label1 = new Label();
            TxtGpu = new TextBox();
            label2 = new Label();
            TxtDisk = new TextBox();
            label3 = new Label();
            TxtOs = new TextBox();
            label4 = new Label();
            TxtBoard = new TextBox();
            SuspendLayout();
            // 
            // LblCpu
            // 
            LblCpu.AutoSize = true;
            LblCpu.Location = new Point(12, 15);
            LblCpu.Name = "LblCpu";
            LblCpu.Size = new Size(41, 15);
            LblCpu.TabIndex = 1;
            LblCpu.Text = "CPU : ";
            // 
            // TxtCpu
            // 
            TxtCpu.Location = new Point(90, 12);
            TxtCpu.Name = "TxtCpu";
            TxtCpu.Size = new Size(387, 23);
            TxtCpu.TabIndex = 2;
            TxtCpu.TextChanged += TxtCpu_TextChanged;
            // 
            // LblRam
            // 
            LblRam.AutoSize = true;
            LblRam.Location = new Point(13, 44);
            LblRam.Name = "LblRam";
            LblRam.Size = new Size(40, 15);
            LblRam.TabIndex = 1;
            LblRam.Text = "RAM :";
            // 
            // TxtRam
            // 
            TxtRam.Location = new Point(90, 41);
            TxtRam.Name = "TxtRam";
            TxtRam.Size = new Size(387, 23);
            TxtRam.TabIndex = 2;
            TxtRam.TextChanged += TxtRam_TextChanged;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(497, 276);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(75, 23);
            BtnRefresh.TabIndex = 3;
            BtnRefresh.Text = "새로고침";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 76);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "VGA :";
            // 
            // TxtGpu
            // 
            TxtGpu.Location = new Point(90, 73);
            TxtGpu.Name = "TxtGpu";
            TxtGpu.Size = new Size(387, 23);
            TxtGpu.TabIndex = 2;
            TxtGpu.TextChanged += TxtRam_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 106);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "DISK :";
            // 
            // TxtDisk
            // 
            TxtDisk.Location = new Point(90, 103);
            TxtDisk.Name = "TxtDisk";
            TxtDisk.Size = new Size(387, 23);
            TxtDisk.TabIndex = 2;
            TxtDisk.TextChanged += TxtRam_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 136);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "OS :";
            // 
            // TxtOs
            // 
            TxtOs.Location = new Point(90, 133);
            TxtOs.Name = "TxtOs";
            TxtOs.Size = new Size(387, 23);
            TxtOs.TabIndex = 2;
            TxtOs.TextChanged += TxtRam_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 166);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 1;
            label4.Text = "M/B";
            // 
            // TxtBoard
            // 
            TxtBoard.Location = new Point(90, 163);
            TxtBoard.Name = "TxtBoard";
            TxtBoard.Size = new Size(387, 23);
            TxtBoard.TabIndex = 2;
            TxtBoard.TextChanged += TxtRam_TextChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnRefresh);
            Controls.Add(TxtBoard);
            Controls.Add(TxtOs);
            Controls.Add(TxtDisk);
            Controls.Add(TxtGpu);
            Controls.Add(TxtRam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblRam);
            Controls.Add(TxtCpu);
            Controls.Add(LblCpu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "윈앱 연습";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCpu;
        private TextBox TxtCpu;
        private Label LblRam;
        private TextBox TxtRam;
        private Button BtnRefresh;
        private Label label1;
        private TextBox TxtGpu;
        private Label label2;
        private TextBox TxtDisk;
        private Label label3;
        private TextBox TxtOs;
        private Label label4;
        private TextBox TxtBoard;
    }
}
