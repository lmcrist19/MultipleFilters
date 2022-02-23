namespace MultipleFilters
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
            this.rawImageBox = new System.Windows.Forms.PictureBox();
            this.whiteIsolationBox = new System.Windows.Forms.PictureBox();
            this.redIsolationBox = new System.Windows.Forms.PictureBox();
            this.rawImageLabel = new System.Windows.Forms.Label();
            this.redIsolationLabel = new System.Windows.Forms.Label();
            this.whiteIsolationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rawImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteIsolationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redIsolationBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rawImageBox
            // 
            this.rawImageBox.Location = new System.Drawing.Point(271, 12);
            this.rawImageBox.Name = "rawImageBox";
            this.rawImageBox.Size = new System.Drawing.Size(261, 196);
            this.rawImageBox.TabIndex = 0;
            this.rawImageBox.TabStop = false;
            // 
            // whiteIsolationBox
            // 
            this.whiteIsolationBox.Location = new System.Drawing.Point(12, 242);
            this.whiteIsolationBox.Name = "whiteIsolationBox";
            this.whiteIsolationBox.Size = new System.Drawing.Size(261, 196);
            this.whiteIsolationBox.TabIndex = 2;
            this.whiteIsolationBox.TabStop = false;
            // 
            // redIsolationBox
            // 
            this.redIsolationBox.Location = new System.Drawing.Point(527, 242);
            this.redIsolationBox.Name = "redIsolationBox";
            this.redIsolationBox.Size = new System.Drawing.Size(261, 196);
            this.redIsolationBox.TabIndex = 5;
            this.redIsolationBox.TabStop = false;
            // 
            // rawImageLabel
            // 
            this.rawImageLabel.AutoSize = true;
            this.rawImageLabel.Location = new System.Drawing.Point(268, 191);
            this.rawImageLabel.Name = "rawImageLabel";
            this.rawImageLabel.Size = new System.Drawing.Size(35, 17);
            this.rawImageLabel.TabIndex = 6;
            this.rawImageLabel.Text = "Raw";
            // 
            // redIsolationLabel
            // 
            this.redIsolationLabel.AutoSize = true;
            this.redIsolationLabel.Location = new System.Drawing.Point(524, 421);
            this.redIsolationLabel.Name = "redIsolationLabel";
            this.redIsolationLabel.Size = new System.Drawing.Size(34, 17);
            this.redIsolationLabel.TabIndex = 7;
            this.redIsolationLabel.Text = "Red";
            // 
            // whiteIsolationLabel
            // 
            this.whiteIsolationLabel.AutoSize = true;
            this.whiteIsolationLabel.Location = new System.Drawing.Point(12, 421);
            this.whiteIsolationLabel.Name = "whiteIsolationLabel";
            this.whiteIsolationLabel.Size = new System.Drawing.Size(44, 17);
            this.whiteIsolationLabel.TabIndex = 8;
            this.whiteIsolationLabel.Text = "White";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.whiteIsolationLabel);
            this.Controls.Add(this.redIsolationLabel);
            this.Controls.Add(this.rawImageLabel);
            this.Controls.Add(this.redIsolationBox);
            this.Controls.Add(this.whiteIsolationBox);
            this.Controls.Add(this.rawImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteIsolationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redIsolationBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rawImageBox;
        private System.Windows.Forms.PictureBox whiteIsolationBox;
        private System.Windows.Forms.PictureBox redIsolationBox;
        private System.Windows.Forms.Label rawImageLabel;
        private System.Windows.Forms.Label redIsolationLabel;
        private System.Windows.Forms.Label whiteIsolationLabel;
    }
}

