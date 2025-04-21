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
            BrtMsg = new Button();
            TexPain = new TextBox();
            CbopainPoint = new ComboBox();
            LblPainPoint = new Label();
            label1 = new Label();
            BtnDisplay = new Button();
            TxtDisplay = new TextBox();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // BrtMsg
            // 
            BrtMsg.BackColor = SystemColors.ActiveCaption;
            BrtMsg.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BrtMsg.Location = new Point(371, 269);
            BrtMsg.Name = "BrtMsg";
            BrtMsg.Size = new Size(117, 34);
            BrtMsg.TabIndex = 3;
            BrtMsg.Text = "메시지";
            BrtMsg.UseVisualStyleBackColor = false;
            BrtMsg.Click += BrtMsg_Click;
            // 
            // TexPain
            // 
            TexPain.Location = new Point(105, 22);
            TexPain.MaxLength = 3;
            TexPain.Name = "TexPain";
            TexPain.PlaceholderText = "네 또는 아니오";
            TexPain.Size = new Size(92, 23);
            TexPain.TabIndex = 1;
            TexPain.TextChanged += TexPain_TextChanged;
            TexPain.KeyPress += TexPain_KeyPress;
            // 
            // CbopainPoint
            // 
            CbopainPoint.FormattingEnabled = true;
            CbopainPoint.Items.AddRange(new object[] { "머리", "목", "어깨", "가슴", "등", "허리", "골반", "다리" });
            CbopainPoint.Location = new Point(105, 63);
            CbopainPoint.Name = "CbopainPoint";
            CbopainPoint.Size = new Size(130, 23);
            CbopainPoint.TabIndex = 3;
            CbopainPoint.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LblPainPoint
            // 
            LblPainPoint.AutoSize = true;
            LblPainPoint.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LblPainPoint.Location = new Point(12, 22);
            LblPainPoint.Name = "LblPainPoint";
            LblPainPoint.Size = new Size(87, 21);
            LblPainPoint.TabIndex = 4;
            LblPainPoint.Text = "통증여부 -";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 5;
            label1.Text = "통증부위 -";
            // 
            // BtnDisplay
            // 
            BtnDisplay.BackColor = SystemColors.ActiveCaption;
            BtnDisplay.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnDisplay.Location = new Point(248, 270);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(117, 34);
            BtnDisplay.TabIndex = 2;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = false;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // TxtDisplay
            // 
            TxtDisplay.Location = new Point(12, 92);
            TxtDisplay.Multiline = true;
            TxtDisplay.Name = "TxtDisplay";
            TxtDisplay.Size = new Size(476, 171);
            TxtDisplay.TabIndex = 7;
            // 
            // BtnWhile
            // 
            BtnWhile.BackColor = SystemColors.ActiveCaption;
            BtnWhile.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnWhile.Location = new Point(125, 269);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(117, 34);
            BtnWhile.TabIndex = 1;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = false;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(500, 315);
            Controls.Add(BtnWhile);
            Controls.Add(TxtDisplay);
            Controls.Add(BtnDisplay);
            Controls.Add(label1);
            Controls.Add(LblPainPoint);
            Controls.Add(CbopainPoint);
            Controls.Add(TexPain);
            Controls.Add(BrtMsg);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = " ";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BrtMsg;
        private TextBox TexPain;
        private ComboBox CbopainPoint;
        private Label LblPainPoint;
        private Label label1;
        private Button BtnDisplay;
        private TextBox TxtDisplay;
        private Button BtnWhile;
    }
}
