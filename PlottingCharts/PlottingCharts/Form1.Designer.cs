
namespace PlottingCharts
{
    partial class frmPlot
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
            this.pnlPlot = new System.Windows.Forms.Panel();
            this.mnuMainPlot = new System.Windows.Forms.MenuStrip();
            this.mnuPlot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlotLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlotBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlotSpiral = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlotPie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlotSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPlotExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainPlot.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlot
            // 
            this.pnlPlot.BackColor = System.Drawing.Color.White;
            this.pnlPlot.Location = new System.Drawing.Point(13, 43);
            this.pnlPlot.Name = "pnlPlot";
            this.pnlPlot.Size = new System.Drawing.Size(1168, 679);
            this.pnlPlot.TabIndex = 0;
            this.pnlPlot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlot_Paint);
            // 
            // mnuMainPlot
            // 
            this.mnuMainPlot.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuMainPlot.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuMainPlot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlot});
            this.mnuMainPlot.Location = new System.Drawing.Point(0, 0);
            this.mnuMainPlot.Name = "mnuMainPlot";
            this.mnuMainPlot.Size = new System.Drawing.Size(1192, 42);
            this.mnuMainPlot.TabIndex = 0;
            this.mnuMainPlot.Text = "menuStrip1";
            // 
            // mnuPlot
            // 
            this.mnuPlot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlotLine,
            this.mnuPlotBar,
            this.mnuPlotSpiral,
            this.mnuPlotPie,
            this.mnuPlotSep,
            this.mnuPlotExit});
            this.mnuPlot.Name = "mnuPlot";
            this.mnuPlot.Size = new System.Drawing.Size(76, 38);
            this.mnuPlot.Text = "&Plot";
            // 
            // mnuPlotLine
            // 
            this.mnuPlotLine.Name = "mnuPlotLine";
            this.mnuPlotLine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuPlotLine.Size = new System.Drawing.Size(359, 44);
            this.mnuPlotLine.Text = "&Line Chart";
            this.mnuPlotLine.Click += new System.EventHandler(this.mnuPlotLine_Click);
            // 
            // mnuPlotBar
            // 
            this.mnuPlotBar.Name = "mnuPlotBar";
            this.mnuPlotBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuPlotBar.Size = new System.Drawing.Size(359, 44);
            this.mnuPlotBar.Text = "&Bar Chart";
            this.mnuPlotBar.Click += new System.EventHandler(this.mnuPlotBar_Click);
            // 
            // mnuPlotSpiral
            // 
            this.mnuPlotSpiral.Name = "mnuPlotSpiral";
            this.mnuPlotSpiral.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuPlotSpiral.Size = new System.Drawing.Size(359, 44);
            this.mnuPlotSpiral.Text = "&Spiral Chart";
            this.mnuPlotSpiral.Click += new System.EventHandler(this.mnuPlotLine_Click);
            // 
            // mnuPlotPie
            // 
            this.mnuPlotPie.Name = "mnuPlotPie";
            this.mnuPlotPie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPlotPie.Size = new System.Drawing.Size(359, 44);
            this.mnuPlotPie.Text = "&Pie Chart";
            this.mnuPlotPie.Click += new System.EventHandler(this.mnuPlotPie_Click);
            // 
            // mnuPlotSep
            // 
            this.mnuPlotSep.Name = "mnuPlotSep";
            this.mnuPlotSep.Size = new System.Drawing.Size(356, 6);
            // 
            // mnuPlotExit
            // 
            this.mnuPlotExit.Name = "mnuPlotExit";
            this.mnuPlotExit.Size = new System.Drawing.Size(359, 44);
            this.mnuPlotExit.Text = "E&xit";
            this.mnuPlotExit.Click += new System.EventHandler(this.mnuPlotExit_Click);
            // 
            // frmPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 734);
            this.Controls.Add(this.pnlPlot);
            this.Controls.Add(this.mnuMainPlot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMainPlot;
            this.Name = "frmPlot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plotting Examples";
            this.Load += new System.EventHandler(this.frmPlot_Load);
            this.mnuMainPlot.ResumeLayout(false);
            this.mnuMainPlot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlot;
        private System.Windows.Forms.MenuStrip mnuMainPlot;
        private System.Windows.Forms.ToolStripMenuItem mnuPlot;
        private System.Windows.Forms.ToolStripMenuItem mnuPlotLine;
        private System.Windows.Forms.ToolStripMenuItem mnuPlotBar;
        private System.Windows.Forms.ToolStripMenuItem mnuPlotSpiral;
        private System.Windows.Forms.ToolStripMenuItem mnuPlotPie;
        private System.Windows.Forms.ToolStripSeparator mnuPlotSep;
        private System.Windows.Forms.ToolStripMenuItem mnuPlotExit;
    }
}

