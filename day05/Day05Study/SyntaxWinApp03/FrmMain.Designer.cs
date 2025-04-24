namespace SyntaxWinApp03
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
            BtnStart = new Button();
            TxtLog = new TextBox();
            label1 = new Label();
            LblCurrState = new ToolStripStatusLabel();
            PrgProcess = new ToolStripProgressBar();
            statusStrip1 = new StatusStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            기모찌ToolStripMenuItem = new ToolStripMenuItem();
            넘모좋아잉ToolStripMenuItem = new ToolStripMenuItem();
            아주좋아잉ToolStripMenuItem = new ToolStripMenuItem();
            좋와잉ToolStripMenuItem = new ToolStripMenuItem();
            좋아ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(472, 256);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(100, 30);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // TxtLog
            // 
            TxtLog.BorderStyle = BorderStyle.FixedSingle;
            TxtLog.Location = new Point(12, 27);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.ScrollBars = ScrollBars.Vertical;
            TxtLog.Size = new Size(560, 223);
            TxtLog.TabIndex = 1;
            TxtLog.TextChanged += TxtLog_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "로그";
            // 
            // LblCurrState
            // 
            LblCurrState.Name = "LblCurrState";
            LblCurrState.Size = new Size(90, 17);
            LblCurrState.Text = "현재상태 : 중지";
            // 
            // PrgProcess
            // 
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(380, 16);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblCurrState, PrgProcess, toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 289);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { 기모찌ToolStripMenuItem, 넘모좋아잉ToolStripMenuItem, 아주좋아잉ToolStripMenuItem, 좋와잉ToolStripMenuItem, 좋아ToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // 기모찌ToolStripMenuItem
            // 
            기모찌ToolStripMenuItem.Name = "기모찌ToolStripMenuItem";
            기모찌ToolStripMenuItem.Size = new Size(138, 22);
            기모찌ToolStripMenuItem.Text = "기모찌";
            // 
            // 넘모좋아잉ToolStripMenuItem
            // 
            넘모좋아잉ToolStripMenuItem.Name = "넘모좋아잉ToolStripMenuItem";
            넘모좋아잉ToolStripMenuItem.Size = new Size(138, 22);
            넘모좋아잉ToolStripMenuItem.Text = "넘모 좋아잉";
            // 
            // 아주좋아잉ToolStripMenuItem
            // 
            아주좋아잉ToolStripMenuItem.Name = "아주좋아잉ToolStripMenuItem";
            아주좋아잉ToolStripMenuItem.Size = new Size(138, 22);
            아주좋아잉ToolStripMenuItem.Text = "아주좋아잉";
            // 
            // 좋와잉ToolStripMenuItem
            // 
            좋와잉ToolStripMenuItem.Name = "좋와잉ToolStripMenuItem";
            좋와잉ToolStripMenuItem.Size = new Size(138, 22);
            좋와잉ToolStripMenuItem.Text = "좋와잉";
            // 
            // 좋아ToolStripMenuItem
            // 
            좋아ToolStripMenuItem.Name = "좋아ToolStripMenuItem";
            좋아ToolStripMenuItem.Size = new Size(138, 22);
            좋아ToolStripMenuItem.Text = "좋아";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(TxtLog);
            Controls.Add(BtnStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "스레드 연습";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private TextBox TxtLog;
        private Label label1;
        private ToolStripStatusLabel LblCurrState;
        private ToolStripProgressBar PrgProcess;
        private StatusStrip statusStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem 기모찌ToolStripMenuItem;
        private ToolStripMenuItem 넘모좋아잉ToolStripMenuItem;
        private ToolStripMenuItem 아주좋아잉ToolStripMenuItem;
        private ToolStripMenuItem 좋와잉ToolStripMenuItem;
        private ToolStripMenuItem 좋아ToolStripMenuItem;
    }
}
