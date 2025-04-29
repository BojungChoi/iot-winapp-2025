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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuSave = new ToolStripMenuItem();
            MnuOpen = new ToolStripMenuItem();
            MnuExist = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            PrgProcess = new ProgressBar();
            toolTip1 = new ToolTip(components);
            ChkBold = new CheckBox();
            ChkItalic = new CheckBox();
            CboFonts = new ComboBox();
            BtnClear = new Button();
            label5 = new Label();
            TimerRefresh = new System.Windows.Forms.Timer(components);
            PbxLoading = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbxLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblCpu
            // 
            LblCpu.AutoSize = true;
            LblCpu.BackColor = Color.Transparent;
            LblCpu.Font = new Font("한컴 고딕", 11.25F);
            LblCpu.ForeColor = Color.Black;
            LblCpu.Location = new Point(12, 71);
            LblCpu.Name = "LblCpu";
            LblCpu.Size = new Size(46, 19);
            LblCpu.TabIndex = 1;
            LblCpu.Text = "CPU :";
            // 
            // TxtCpu
            // 
            TxtCpu.BorderStyle = BorderStyle.FixedSingle;
            TxtCpu.Location = new Point(58, 69);
            TxtCpu.Name = "TxtCpu";
            TxtCpu.Size = new Size(418, 23);
            TxtCpu.TabIndex = 2;
            // 
            // LblRam
            // 
            LblRam.AutoSize = true;
            LblRam.BackColor = Color.Transparent;
            LblRam.Font = new Font("한컴 고딕", 11.25F);
            LblRam.ForeColor = Color.Black;
            LblRam.Location = new Point(9, 110);
            LblRam.Name = "LblRam";
            LblRam.Size = new Size(49, 19);
            LblRam.TabIndex = 1;
            LblRam.Text = "RAM :";
            // 
            // TxtRam
            // 
            TxtRam.BorderStyle = BorderStyle.FixedSingle;
            TxtRam.Location = new Point(58, 107);
            TxtRam.Name = "TxtRam";
            TxtRam.Size = new Size(418, 23);
            TxtRam.TabIndex = 2;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Bold);
            BtnRefresh.Location = new Point(522, 276);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(100, 30);
            BtnRefresh.TabIndex = 3;
            BtnRefresh.Text = "불러오기";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            BtnRefresh.MouseEnter += BtnRefresh_MouseEnter;
            BtnRefresh.MouseLeave += BtnRefresh_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("한컴 고딕", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 150);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 1;
            label1.Text = "VGA :";
            // 
            // TxtGpu
            // 
            TxtGpu.BorderStyle = BorderStyle.FixedSingle;
            TxtGpu.Location = new Point(58, 147);
            TxtGpu.Name = "TxtGpu";
            TxtGpu.Size = new Size(418, 23);
            TxtGpu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("한컴 고딕", 11.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 189);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 1;
            label2.Text = "DISK :";
            // 
            // TxtDisk
            // 
            TxtDisk.BorderStyle = BorderStyle.FixedSingle;
            TxtDisk.Location = new Point(58, 187);
            TxtDisk.Name = "TxtDisk";
            TxtDisk.Size = new Size(418, 23);
            TxtDisk.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("한컴 고딕", 11.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 229);
            label3.Name = "label3";
            label3.Size = new Size(37, 19);
            label3.TabIndex = 1;
            label3.Text = "OS :";
            // 
            // TxtOs
            // 
            TxtOs.BorderStyle = BorderStyle.FixedSingle;
            TxtOs.Location = new Point(58, 227);
            TxtOs.Name = "TxtOs";
            TxtOs.Size = new Size(418, 23);
            TxtOs.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("한컴 고딕", 11.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 266);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 1;
            label4.Text = "M/B :";
            // 
            // TxtBoard
            // 
            TxtBoard.BorderStyle = BorderStyle.FixedSingle;
            TxtBoard.Location = new Point(58, 263);
            TxtBoard.Name = "TxtBoard";
            TxtBoard.Size = new Size(418, 23);
            TxtBoard.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(634, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuSave, MnuOpen, MnuExist });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuSave
            // 
            MnuSave.Name = "MnuSave";
            MnuSave.Size = new Size(139, 22);
            MnuSave.Text = "저장(&S)";
            MnuSave.Click += MnuSave_Click;
            // 
            // MnuOpen
            // 
            MnuOpen.Name = "MnuOpen";
            MnuOpen.Size = new Size(139, 22);
            MnuOpen.Text = "불러오기(&O)";
            MnuOpen.Click += MnuOpen_Click;
            // 
            // MnuExist
            // 
            MnuExist.Name = "MnuExist";
            MnuExist.Size = new Size(139, 22);
            MnuExist.Text = "종료(&X)";
            MnuExist.Click += MnuExist_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 309);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(634, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.BackColor = Color.Transparent;
            LblState.Name = "LblState";
            LblState.Size = new Size(90, 17);
            LblState.Text = "현재상태 : 정상";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(32, 293);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(474, 13);
            PrgProcess.TabIndex = 6;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.BackColor = Color.Transparent;
            ChkBold.Font = new Font("한컴 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ChkBold.Location = new Point(316, 39);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(54, 21);
            ChkBold.TabIndex = 7;
            ChkBold.Text = "Bold";
            ChkBold.UseVisualStyleBackColor = false;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.BackColor = Color.Transparent;
            ChkItalic.Font = new Font("맑은 고딕 Semilight", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 129);
            ChkItalic.Location = new Point(376, 39);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(53, 21);
            ChkItalic.TabIndex = 7;
            ChkItalic.Text = "Italic";
            ChkItalic.UseVisualStyleBackColor = false;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(153, 37);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(157, 23);
            CboFonts.TabIndex = 8;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Bold);
            BtnClear.Location = new Point(522, 247);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(100, 30);
            BtnClear.TabIndex = 3;
            BtnClear.Text = "초기화";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            BtnClear.MouseEnter += BtnClear_MouseEnter;
            BtnClear.MouseLeave += BtnClear_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("한컴 고딕", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(58, 39);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 9;
            label5.Text = "글씨체 변경";
            // 
            // PbxLoading
            // 
            PbxLoading.BackgroundImageLayout = ImageLayout.None;
            PbxLoading.Image = (Image)resources.GetObject("PbxLoading.Image");
            PbxLoading.Location = new Point(549, 204);
            PbxLoading.Name = "PbxLoading";
            PbxLoading.Size = new Size(43, 39);
            PbxLoading.TabIndex = 10;
            PbxLoading.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(634, 331);
            Controls.Add(PbxLoading);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(CboFonts);
            Controls.Add(ChkItalic);
            Controls.Add(ChkBold);
            Controls.Add(PrgProcess);
            Controls.Add(statusStrip1);
            Controls.Add(BtnClear);
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
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Computer";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbxLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuExist;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LblState;
        private ProgressBar PrgProcess;
        private ToolTip toolTip1;
        private CheckBox ChkBold;
        private CheckBox ChkItalic;
        private ComboBox CboFonts;
        private Button BtnClear;
        private Label label5;
        private ToolStripMenuItem MnuSave;
        private ToolStripMenuItem MnuOpen;
        private System.Windows.Forms.Timer TimerRefresh;
        private PictureBox PbxLoading;
        private PictureBox pictureBox1;
    }
}
