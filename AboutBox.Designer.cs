namespace TwilightShards.genLibrary
{
    partial class AboutBox
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
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblPrgName = new System.Windows.Forms.Label();
            this.lblVerText = new System.Windows.Forms.Label();
            this.lblAboutText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIcon
            // 
            this.lblIcon.Image = global::TwilightShards.genLibrary.Properties.Resources.info;
            this.lblIcon.Location = new System.Drawing.Point(12, 11);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(128, 132);
            this.lblIcon.TabIndex = 0;
            // 
            // lblPrgName
            // 
            this.lblPrgName.AutoSize = true;
            this.lblPrgName.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrgName.ForeColor = System.Drawing.Color.Red;
            this.lblPrgName.Location = new System.Drawing.Point(173, 17);
            this.lblPrgName.Name = "lblPrgName";
            this.lblPrgName.Size = new System.Drawing.Size(76, 38);
            this.lblPrgName.TabIndex = 1;
            this.lblPrgName.Text = "Text";
            // 
            // lblVerText
            // 
            this.lblVerText.AutoSize = true;
            this.lblVerText.Location = new System.Drawing.Point(177, 74);
            this.lblVerText.Name = "lblVerText";
            this.lblVerText.Size = new System.Drawing.Size(35, 13);
            this.lblVerText.TabIndex = 2;
            this.lblVerText.Text = "label1";
            // 
            // lblAboutText
            // 
            this.lblAboutText.Location = new System.Drawing.Point(25, 170);
            this.lblAboutText.Name = "lblAboutText";
            this.lblAboutText.Size = new System.Drawing.Size(393, 292);
            this.lblAboutText.TabIndex = 3;
            this.lblAboutText.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(169, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 511);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAboutText);
            this.Controls.Add(this.lblVerText);
            this.Controls.Add(this.lblPrgName);
            this.Controls.Add(this.lblIcon);
            this.Name = "AboutBox";
            this.Text = "AboutBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblPrgName;
        private System.Windows.Forms.Label lblVerText;
        private System.Windows.Forms.Label lblAboutText;
        private System.Windows.Forms.Button btnClose;
    }
}