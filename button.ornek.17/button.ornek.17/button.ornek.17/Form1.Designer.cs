namespace button.ornek._17
{
    partial class lblBlue
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
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(46, 38);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(320, 45);
            this.tbRed.TabIndex = 0;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(46, 153);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(320, 45);
            this.tbBlue.TabIndex = 1;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(46, 89);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(320, 45);
            this.tbGreen.TabIndex = 2;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(402, 53);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(402, 100);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 4;
            this.lblGreen.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // lblBlue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbRed);
            this.Name = "lblBlue";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label label3;
    }
}

