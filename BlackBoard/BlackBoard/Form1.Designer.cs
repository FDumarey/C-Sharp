
namespace BlackBoard
{
    partial class frmBlackBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.lblLeftColor = new System.Windows.Forms.Label();
            this.lblRightColor = new System.Windows.Forms.Label();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.lblWhite = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblMagenta = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblCyan = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGray = new System.Windows.Forms.Label();
            this.mnuBlackBoard = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPolygons = new System.Windows.Forms.CheckBox();
            this.grpPolygons = new System.Windows.Forms.GroupBox();
            this.rdoCurves = new System.Windows.Forms.RadioButton();
            this.rdoLines = new System.Windows.Forms.RadioButton();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.timCurve = new System.Windows.Forms.Timer(this.components);
            this.chkAnimation = new System.Windows.Forms.CheckBox();
            this.grpColors.SuspendLayout();
            this.mnuBlackBoard.SuspendLayout();
            this.grpPolygons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.Black;
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDraw.Location = new System.Drawing.Point(39, 91);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(1661, 1074);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            this.pnlDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseUp);
            // 
            // lblLeftColor
            // 
            this.lblLeftColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeftColor.Location = new System.Drawing.Point(1739, 89);
            this.lblLeftColor.Name = "lblLeftColor";
            this.lblLeftColor.Size = new System.Drawing.Size(68, 69);
            this.lblLeftColor.TabIndex = 1;
            // 
            // lblRightColor
            // 
            this.lblRightColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRightColor.Location = new System.Drawing.Point(1988, 91);
            this.lblRightColor.Name = "lblRightColor";
            this.lblRightColor.Size = new System.Drawing.Size(70, 67);
            this.lblRightColor.TabIndex = 2;
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.lblWhite);
            this.grpColors.Controls.Add(this.lblYellow);
            this.grpColors.Controls.Add(this.lblMagenta);
            this.grpColors.Controls.Add(this.lblRed);
            this.grpColors.Controls.Add(this.lblCyan);
            this.grpColors.Controls.Add(this.lblGreen);
            this.grpColors.Controls.Add(this.lblBlue);
            this.grpColors.Controls.Add(this.lblGray);
            this.grpColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColors.Location = new System.Drawing.Point(1739, 180);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(319, 381);
            this.grpColors.TabIndex = 3;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Colors";
            // 
            // lblWhite
            // 
            this.lblWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhite.Location = new System.Drawing.Point(177, 308);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(70, 25);
            this.lblWhite.TabIndex = 7;
            this.lblWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblColor_MouseDown);
            // 
            // lblYellow
            // 
            this.lblYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYellow.Location = new System.Drawing.Point(31, 309);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(70, 25);
            this.lblYellow.TabIndex = 6;
            this.lblYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblColor_MouseDown);
            // 
            // lblMagenta
            // 
            this.lblMagenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMagenta.Location = new System.Drawing.Point(177, 228);
            this.lblMagenta.Name = "lblMagenta";
            this.lblMagenta.Size = new System.Drawing.Size(70, 25);
            this.lblMagenta.TabIndex = 5;
            this.lblMagenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblColor_MouseDown);
            // 
            // lblRed
            // 
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRed.Location = new System.Drawing.Point(31, 228);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(70, 25);
            this.lblRed.TabIndex = 4;
            this.lblRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblColor_MouseDown);
            // 
            // lblCyan
            // 
            this.lblCyan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCyan.Location = new System.Drawing.Point(177, 148);
            this.lblCyan.Name = "lblCyan";
            this.lblCyan.Size = new System.Drawing.Size(70, 25);
            this.lblCyan.TabIndex = 3;
            this.lblCyan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblColor_MouseDown);
            // 
            // lblGreen
            // 
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGreen.Location = new System.Drawing.Point(31, 148);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(70, 25);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblColor_MouseDown);
            // 
            // lblBlue
            // 
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlue.Location = new System.Drawing.Point(177, 68);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(70, 25);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblColor_MouseDown);
            // 
            // lblGray
            // 
            this.lblGray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGray.Location = new System.Drawing.Point(31, 68);
            this.lblGray.Name = "lblGray";
            this.lblGray.Size = new System.Drawing.Size(70, 25);
            this.lblGray.TabIndex = 0;
            this.lblGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblColor_MouseDown);
            // 
            // mnuBlackBoard
            // 
            this.mnuBlackBoard.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuBlackBoard.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuBlackBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuBlackBoard.Location = new System.Drawing.Point(0, 0);
            this.mnuBlackBoard.Name = "mnuBlackBoard";
            this.mnuBlackBoard.Size = new System.Drawing.Size(2070, 40);
            this.mnuBlackBoard.TabIndex = 4;
            this.mnuBlackBoard.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileSep,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(72, 36);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(197, 44);
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileSep
            // 
            this.mnuFileSep.Name = "mnuFileSep";
            this.mnuFileSep.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(197, 44);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1813, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1920, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Right";
            // 
            // chkPolygons
            // 
            this.chkPolygons.AutoSize = true;
            this.chkPolygons.Location = new System.Drawing.Point(1739, 607);
            this.chkPolygons.Name = "chkPolygons";
            this.chkPolygons.Size = new System.Drawing.Size(186, 29);
            this.chkPolygons.TabIndex = 7;
            this.chkPolygons.Text = "&Draw polygons";
            this.chkPolygons.UseVisualStyleBackColor = true;
            // 
            // grpPolygons
            // 
            this.grpPolygons.Controls.Add(this.rdoCurves);
            this.grpPolygons.Controls.Add(this.rdoLines);
            this.grpPolygons.Controls.Add(this.btnFill);
            this.grpPolygons.Controls.Add(this.btnClose);
            this.grpPolygons.Controls.Add(this.btnDraw);
            this.grpPolygons.Location = new System.Drawing.Point(1739, 684);
            this.grpPolygons.Name = "grpPolygons";
            this.grpPolygons.Size = new System.Drawing.Size(319, 416);
            this.grpPolygons.TabIndex = 8;
            this.grpPolygons.TabStop = false;
            this.grpPolygons.Text = "Polygons";
            // 
            // rdoCurves
            // 
            this.rdoCurves.AutoSize = true;
            this.rdoCurves.Location = new System.Drawing.Point(23, 356);
            this.rdoCurves.Name = "rdoCurves";
            this.rdoCurves.Size = new System.Drawing.Size(111, 29);
            this.rdoCurves.TabIndex = 4;
            this.rdoCurves.Text = "Curves";
            this.rdoCurves.UseVisualStyleBackColor = true;
            // 
            // rdoLines
            // 
            this.rdoLines.AutoSize = true;
            this.rdoLines.Checked = true;
            this.rdoLines.Location = new System.Drawing.Point(23, 310);
            this.rdoLines.Name = "rdoLines";
            this.rdoLines.Size = new System.Drawing.Size(95, 29);
            this.rdoLines.TabIndex = 3;
            this.rdoLines.TabStop = true;
            this.rdoLines.Text = "Lines";
            this.rdoLines.UseVisualStyleBackColor = true;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(23, 221);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(272, 57);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "&Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(23, 142);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(272, 57);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(23, 65);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(272, 57);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "D&raw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // timCurve
            // 
            this.timCurve.Tick += new System.EventHandler(this.timCurve_Tick);
            // 
            // chkAnimation
            // 
            this.chkAnimation.AutoSize = true;
            this.chkAnimation.Location = new System.Drawing.Point(1739, 1136);
            this.chkAnimation.Name = "chkAnimation";
            this.chkAnimation.Size = new System.Drawing.Size(204, 29);
            this.chkAnimation.TabIndex = 9;
            this.chkAnimation.Text = "&Animate polygon";
            this.chkAnimation.UseVisualStyleBackColor = true;
            // 
            // frmBlackBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2070, 1222);
            this.Controls.Add(this.chkAnimation);
            this.Controls.Add(this.grpPolygons);
            this.Controls.Add(this.chkPolygons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpColors);
            this.Controls.Add(this.lblRightColor);
            this.Controls.Add(this.lblLeftColor);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.mnuBlackBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuBlackBoard;
            this.Name = "frmBlackBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackBoard © 2020";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBlackBoard_FormClosing);
            this.Load += new System.EventHandler(this.frmBlackBoard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBlackBoard_Paint);
            this.grpColors.ResumeLayout(false);
            this.mnuBlackBoard.ResumeLayout(false);
            this.mnuBlackBoard.PerformLayout();
            this.grpPolygons.ResumeLayout(false);
            this.grpPolygons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Label lblLeftColor;
        private System.Windows.Forms.Label lblRightColor;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblMagenta;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblCyan;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGray;
        private System.Windows.Forms.MenuStrip mnuBlackBoard;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripSeparator mnuFileSep;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPolygons;
        private System.Windows.Forms.GroupBox grpPolygons;
        private System.Windows.Forms.RadioButton rdoCurves;
        private System.Windows.Forms.RadioButton rdoLines;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Timer timCurve;
        private System.Windows.Forms.CheckBox chkAnimation;
    }
}

