
namespace BouncingBall
{
    partial class frmBall
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
            this.timBall = new System.Windows.Forms.Timer(this.components);
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.timScroll = new System.Windows.Forms.Timer(this.components);
            this.hsbScroll = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // timBall
            // 
            this.timBall.Interval = 25;
            this.timBall.Tick += new System.EventHandler(this.timBall_Tick);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.LightBlue;
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplay.Location = new System.Drawing.Point(13, 13);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(841, 1192);
            this.pnlDisplay.TabIndex = 0;
            this.pnlDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDisplay_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(902, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(562, 79);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlViewer
            // 
            this.pnlViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewer.Location = new System.Drawing.Point(902, 807);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(562, 398);
            this.pnlViewer.TabIndex = 2;
            // 
            // timScroll
            // 
            this.timScroll.Enabled = true;
            this.timScroll.Interval = 25;
            this.timScroll.Tick += new System.EventHandler(this.timScroll_Tick);
            // 
            // hsbScroll
            // 
            this.hsbScroll.LargeChange = 2;
            this.hsbScroll.Location = new System.Drawing.Point(902, 740);
            this.hsbScroll.Maximum = 20;
            this.hsbScroll.Name = "hsbScroll";
            this.hsbScroll.Size = new System.Drawing.Size(562, 34);
            this.hsbScroll.TabIndex = 3;
            // 
            // frmBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1306);
            this.Controls.Add(this.hsbScroll);
            this.Controls.Add(this.pnlViewer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmBall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bouncing Ball";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBall_FormClosing);
            this.Load += new System.EventHandler(this.frmBall_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBall_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timBall;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlViewer;
        private System.Windows.Forms.Timer timScroll;
        private System.Windows.Forms.HScrollBar hsbScroll;
    }
}

