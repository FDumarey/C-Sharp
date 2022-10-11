namespace DrawingApp
{
    partial class frmLine
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
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnNoLines = new System.Windows.Forms.Button();
            this.grpLines = new System.Windows.Forms.GroupBox();
            this.grpFourPoints = new System.Windows.Forms.GroupBox();
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.rdoEllipse = new System.Windows.Forms.RadioButton();
            this.btnDrawRE = new System.Windows.Forms.Button();
            this.btnFillRE = new System.Windows.Forms.Button();
            this.btnClearRE = new System.Windows.Forms.Button();
            this.grpPie = new System.Windows.Forms.GroupBox();
            this.btnDrawPie = new System.Windows.Forms.Button();
            this.btnClearPie = new System.Windows.Forms.Button();
            this.grpLines.SuspendLayout();
            this.grpFourPoints.SuspendLayout();
            this.grpPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDraw.Location = new System.Drawing.Point(24, 25);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(1436, 615);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(35, 48);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(155, 63);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "Draw &Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnNoLines
            // 
            this.btnNoLines.Location = new System.Drawing.Point(35, 128);
            this.btnNoLines.Name = "btnNoLines";
            this.btnNoLines.Size = new System.Drawing.Size(155, 63);
            this.btnNoLines.TabIndex = 2;
            this.btnNoLines.Text = "Clear L&ines";
            this.btnNoLines.UseVisualStyleBackColor = true;
            this.btnNoLines.Click += new System.EventHandler(this.btnNoLines_Click);
            // 
            // grpLines
            // 
            this.grpLines.Controls.Add(this.btnLine);
            this.grpLines.Controls.Add(this.btnNoLines);
            this.grpLines.Location = new System.Drawing.Point(30, 689);
            this.grpLines.Name = "grpLines";
            this.grpLines.Size = new System.Drawing.Size(240, 299);
            this.grpLines.TabIndex = 3;
            this.grpLines.TabStop = false;
            this.grpLines.Text = "Lines";
            // 
            // grpFourPoints
            // 
            this.grpFourPoints.Controls.Add(this.btnClearRE);
            this.grpFourPoints.Controls.Add(this.btnFillRE);
            this.grpFourPoints.Controls.Add(this.btnDrawRE);
            this.grpFourPoints.Controls.Add(this.rdoEllipse);
            this.grpFourPoints.Controls.Add(this.rdoRectangle);
            this.grpFourPoints.Location = new System.Drawing.Point(325, 689);
            this.grpFourPoints.Name = "grpFourPoints";
            this.grpFourPoints.Size = new System.Drawing.Size(283, 299);
            this.grpFourPoints.TabIndex = 4;
            this.grpFourPoints.TabStop = false;
            this.grpFourPoints.Text = "Rectangles and Ellipses";
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Checked = true;
            this.rdoRectangle.Location = new System.Drawing.Point(7, 48);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(140, 29);
            this.rdoRectangle.TabIndex = 0;
            this.rdoRectangle.TabStop = true;
            this.rdoRectangle.Text = "&Rectangle";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            this.rdoRectangle.CheckedChanged += new System.EventHandler(this.rdoRectangle_CheckedChanged);
            // 
            // rdoEllipse
            // 
            this.rdoEllipse.AutoSize = true;
            this.rdoEllipse.Location = new System.Drawing.Point(7, 83);
            this.rdoEllipse.Name = "rdoEllipse";
            this.rdoEllipse.Size = new System.Drawing.Size(107, 29);
            this.rdoEllipse.TabIndex = 1;
            this.rdoEllipse.Text = "&Ellipse";
            this.rdoEllipse.UseVisualStyleBackColor = true;
            this.rdoEllipse.CheckedChanged += new System.EventHandler(this.rdoRectangle_CheckedChanged);
            // 
            // btnDrawRE
            // 
            this.btnDrawRE.Location = new System.Drawing.Point(7, 128);
            this.btnDrawRE.Name = "btnDrawRE";
            this.btnDrawRE.Size = new System.Drawing.Size(165, 47);
            this.btnDrawRE.TabIndex = 2;
            this.btnDrawRE.Text = "Draw &RE";
            this.btnDrawRE.UseVisualStyleBackColor = true;
            this.btnDrawRE.Click += new System.EventHandler(this.btnDrawRE_Click);
            // 
            // btnFillRE
            // 
            this.btnFillRE.Location = new System.Drawing.Point(7, 181);
            this.btnFillRE.Name = "btnFillRE";
            this.btnFillRE.Size = new System.Drawing.Size(165, 47);
            this.btnFillRE.TabIndex = 3;
            this.btnFillRE.Text = "&Fill RE";
            this.btnFillRE.UseVisualStyleBackColor = true;
            this.btnFillRE.Click += new System.EventHandler(this.btnFillRE_Click);
            // 
            // btnClearRE
            // 
            this.btnClearRE.Location = new System.Drawing.Point(7, 234);
            this.btnClearRE.Name = "btnClearRE";
            this.btnClearRE.Size = new System.Drawing.Size(165, 47);
            this.btnClearRE.TabIndex = 4;
            this.btnClearRE.Text = "Clear R&E";
            this.btnClearRE.UseVisualStyleBackColor = true;
            this.btnClearRE.Click += new System.EventHandler(this.btnClearRE_Click);
            // 
            // grpPie
            // 
            this.grpPie.Controls.Add(this.btnClearPie);
            this.grpPie.Controls.Add(this.btnDrawPie);
            this.grpPie.Location = new System.Drawing.Point(661, 689);
            this.grpPie.Name = "grpPie";
            this.grpPie.Size = new System.Drawing.Size(202, 299);
            this.grpPie.TabIndex = 5;
            this.grpPie.TabStop = false;
            this.grpPie.Text = "Pie";
            // 
            // btnDrawPie
            // 
            this.btnDrawPie.Location = new System.Drawing.Point(7, 48);
            this.btnDrawPie.Name = "btnDrawPie";
            this.btnDrawPie.Size = new System.Drawing.Size(154, 63);
            this.btnDrawPie.TabIndex = 0;
            this.btnDrawPie.Text = "Draw/Fill &Pie";
            this.btnDrawPie.UseVisualStyleBackColor = true;
            this.btnDrawPie.Click += new System.EventHandler(this.btnDrawPie_Click);
            // 
            // btnClearPie
            // 
            this.btnClearPie.Location = new System.Drawing.Point(7, 128);
            this.btnClearPie.Name = "btnClearPie";
            this.btnClearPie.Size = new System.Drawing.Size(154, 63);
            this.btnClearPie.TabIndex = 1;
            this.btnClearPie.Text = "Clear Pi&e";
            this.btnClearPie.UseVisualStyleBackColor = true;
            this.btnClearPie.Click += new System.EventHandler(this.btnClearPie_Click);
            // 
            // frmLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 1038);
            this.Controls.Add(this.grpPie);
            this.Controls.Add(this.grpFourPoints);
            this.Controls.Add(this.grpLines);
            this.Controls.Add(this.pnlDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing Application";
            this.Load += new System.EventHandler(this.frmLine_Load);
            this.grpLines.ResumeLayout(false);
            this.grpFourPoints.ResumeLayout(false);
            this.grpFourPoints.PerformLayout();
            this.grpPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnNoLines;
        private System.Windows.Forms.GroupBox grpLines;
        private System.Windows.Forms.GroupBox grpFourPoints;
        private System.Windows.Forms.Button btnClearRE;
        private System.Windows.Forms.Button btnFillRE;
        private System.Windows.Forms.Button btnDrawRE;
        private System.Windows.Forms.RadioButton rdoEllipse;
        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.GroupBox grpPie;
        private System.Windows.Forms.Button btnClearPie;
        private System.Windows.Forms.Button btnDrawPie;
    }
}

