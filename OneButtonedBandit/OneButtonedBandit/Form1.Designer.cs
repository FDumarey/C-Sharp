namespace OneButtonedBandit
{
    partial class Form1
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
            this.pnlBandit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.picChoice3 = new System.Windows.Forms.PictureBox();
            this.picChoice2 = new System.Windows.Forms.PictureBox();
            this.picChoice1 = new System.Windows.Forms.PictureBox();
            this.picChoice0 = new System.Windows.Forms.PictureBox();
            this.picBandit2 = new System.Windows.Forms.PictureBox();
            this.picBandit1 = new System.Windows.Forms.PictureBox();
            this.picBandit0 = new System.Windows.Forms.PictureBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timSpin = new System.Windows.Forms.Timer(this.components);
            this.timDone = new System.Windows.Forms.Timer(this.components);
            this.pnlBandit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandit0)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBandit
            // 
            this.pnlBandit.BackColor = System.Drawing.Color.Blue;
            this.pnlBandit.Controls.Add(this.picBandit2);
            this.pnlBandit.Controls.Add(this.picBandit1);
            this.pnlBandit.Controls.Add(this.picBandit0);
            this.pnlBandit.Controls.Add(this.lblBank);
            this.pnlBandit.Controls.Add(this.label1);
            this.pnlBandit.Location = new System.Drawing.Point(12, 23);
            this.pnlBandit.Name = "pnlBandit";
            this.pnlBandit.Size = new System.Drawing.Size(1018, 534);
            this.pnlBandit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(111, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bankroll";
            // 
            // lblBank
            // 
            this.lblBank.BackColor = System.Drawing.Color.White;
            this.lblBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.Color.Black;
            this.lblBank.Location = new System.Drawing.Point(437, 59);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(161, 42);
            this.lblBank.TabIndex = 1;
            this.lblBank.Text = "100";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picChoice3
            // 
            this.picChoice3.Image = global::OneButtonedBandit.Properties.Resources.JACKPOT;
            this.picChoice3.Location = new System.Drawing.Point(330, 599);
            this.picChoice3.Name = "picChoice3";
            this.picChoice3.Size = new System.Drawing.Size(100, 133);
            this.picChoice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice3.TabIndex = 4;
            this.picChoice3.TabStop = false;
            this.picChoice3.Visible = false;
            // 
            // picChoice2
            // 
            this.picChoice2.Image = global::OneButtonedBandit.Properties.Resources.BULLSEYE;
            this.picChoice2.Location = new System.Drawing.Point(224, 599);
            this.picChoice2.Name = "picChoice2";
            this.picChoice2.Size = new System.Drawing.Size(100, 133);
            this.picChoice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice2.TabIndex = 3;
            this.picChoice2.TabStop = false;
            this.picChoice2.Visible = false;
            // 
            // picChoice1
            // 
            this.picChoice1.Image = global::OneButtonedBandit.Properties.Resources.BALL;
            this.picChoice1.Location = new System.Drawing.Point(118, 599);
            this.picChoice1.Name = "picChoice1";
            this.picChoice1.Size = new System.Drawing.Size(100, 133);
            this.picChoice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice1.TabIndex = 2;
            this.picChoice1.TabStop = false;
            this.picChoice1.Visible = false;
            // 
            // picChoice0
            // 
            this.picChoice0.Image = global::OneButtonedBandit.Properties.Resources.ARROW;
            this.picChoice0.Location = new System.Drawing.Point(12, 599);
            this.picChoice0.Name = "picChoice0";
            this.picChoice0.Size = new System.Drawing.Size(100, 133);
            this.picChoice0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice0.TabIndex = 1;
            this.picChoice0.TabStop = false;
            this.picChoice0.Visible = false;
            // 
            // picBandit2
            // 
            this.picBandit2.BackColor = System.Drawing.Color.White;
            this.picBandit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBandit2.Location = new System.Drawing.Point(699, 148);
            this.picBandit2.Name = "picBandit2";
            this.picBandit2.Size = new System.Drawing.Size(267, 349);
            this.picBandit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBandit2.TabIndex = 4;
            this.picBandit2.TabStop = false;
            // 
            // picBandit1
            // 
            this.picBandit1.BackColor = System.Drawing.Color.White;
            this.picBandit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBandit1.Location = new System.Drawing.Point(371, 148);
            this.picBandit1.Name = "picBandit1";
            this.picBandit1.Size = new System.Drawing.Size(267, 349);
            this.picBandit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBandit1.TabIndex = 3;
            this.picBandit1.TabStop = false;
            // 
            // picBandit0
            // 
            this.picBandit0.BackColor = System.Drawing.Color.White;
            this.picBandit0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBandit0.Location = new System.Drawing.Point(46, 148);
            this.picBandit0.Name = "picBandit0";
            this.picBandit0.Size = new System.Drawing.Size(267, 349);
            this.picBandit0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBandit0.TabIndex = 2;
            this.picBandit0.TabStop = false;
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSpin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSpin.FlatAppearance.BorderSize = 3;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(531, 599);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(499, 70);
            this.btnSpin.TabIndex = 5;
            this.btnSpin.Text = "&Spin it";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(835, 686);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timSpin
            // 
            this.timSpin.Tick += new System.EventHandler(this.timSpin_Tick);
            // 
            // timDone
            // 
            this.timDone.Interval = 2000;
            this.timDone.Tick += new System.EventHandler(this.timDone_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 761);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.picChoice3);
            this.Controls.Add(this.picChoice2);
            this.Controls.Add(this.picChoice1);
            this.Controls.Add(this.picChoice0);
            this.Controls.Add(this.pnlBandit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "One button Bandit game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBandit.ResumeLayout(false);
            this.pnlBandit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandit0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBandit;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBandit2;
        private System.Windows.Forms.PictureBox picBandit1;
        private System.Windows.Forms.PictureBox picBandit0;
        private System.Windows.Forms.PictureBox picChoice0;
        private System.Windows.Forms.PictureBox picChoice1;
        private System.Windows.Forms.PictureBox picChoice2;
        private System.Windows.Forms.PictureBox picChoice3;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timSpin;
        private System.Windows.Forms.Timer timDone;
    }
}

