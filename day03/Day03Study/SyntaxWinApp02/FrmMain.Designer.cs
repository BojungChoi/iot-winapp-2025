namespace SyntaxWinApp02
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
            BtnCheck = new Button();
            ImlForm = new ImageList(components);
            PicComputer = new PictureBox();
            ImlBigImg = new ImageList(components);
            CboDivision = new ComboBox();
            LblDivision = new Label();
            BtnCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)PicComputer).BeginInit();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.BackgroundImageLayout = ImageLayout.None;
            BtnCheck.Cursor = Cursors.Hand;
            BtnCheck.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCheck.ImageIndex = 0;
            BtnCheck.ImageList = ImlForm;
            BtnCheck.Location = new Point(486, 259);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Padding = new Padding(10, 0, 0, 0);
            BtnCheck.Size = new Size(86, 40);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "      확 인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // ImlForm
            // 
            ImlForm.ColorDepth = ColorDepth.Depth32Bit;
            ImlForm.ImageStream = (ImageListStreamer)resources.GetObject("ImlForm.ImageStream");
            ImlForm.TransparentColor = Color.Transparent;
            ImlForm.Images.SetKeyName(0, "check.png");
            ImlForm.Images.SetKeyName(1, "plus.png");
            // 
            // PicComputer
            // 
            PicComputer.BackColor = SystemColors.Control;
            PicComputer.Location = new Point(12, 12);
            PicComputer.Name = "PicComputer";
            PicComputer.Size = new Size(280, 287);
            PicComputer.SizeMode = PictureBoxSizeMode.StretchImage;
            PicComputer.TabIndex = 1;
            PicComputer.TabStop = false;
            // 
            // ImlBigImg
            // 
            ImlBigImg.ColorDepth = ColorDepth.Depth32Bit;
            ImlBigImg.ImageSize = new Size(256, 256);
            ImlBigImg.TransparentColor = Color.Transparent;
            // 
            // CboDivision
            // 
            CboDivision.FormattingEnabled = true;
            CboDivision.Items.AddRange(new object[] { "Computer", "Notebook", "Server" });
            CboDivision.Location = new Point(451, 12);
            CboDivision.Name = "CboDivision";
            CboDivision.Size = new Size(121, 23);
            CboDivision.TabIndex = 2;
            // 
            // LblDivision
            // 
            LblDivision.AutoSize = true;
            LblDivision.Location = new Point(411, 15);
            LblDivision.Name = "LblDivision";
            LblDivision.Size = new Size(34, 15);
            LblDivision.TabIndex = 3;
            LblDivision.Text = "종류:";
            // 
            // BtnCopy
            // 
            BtnCopy.BackgroundImageLayout = ImageLayout.None;
            BtnCopy.Cursor = Cursors.Hand;
            BtnCopy.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCopy.ImageIndex = 1;
            BtnCopy.ImageList = ImlForm;
            BtnCopy.Location = new Point(394, 259);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Padding = new Padding(10, 0, 0, 0);
            BtnCopy.Size = new Size(86, 40);
            BtnCopy.TabIndex = 0;
            BtnCopy.Text = "     복 사";
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 311);
            Controls.Add(LblDivision);
            Controls.Add(CboDivision);
            Controls.Add(PicComputer);
            Controls.Add(BtnCopy);
            Controls.Add(BtnCheck);
            Name = "FrmMain";
            Text = "문법학습 윈앱02";
            ((System.ComponentModel.ISupportInitialize)PicComputer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private ImageList ImlForm;
        private PictureBox PicComputer;
        private ImageList ImlBigImg;
        private ComboBox CboDivision;
        private Label LblDivision;
        private Button BtnCopy;
    }
}
