namespace CK2MusicFileCreator
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
            this.getFilesButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.generateFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getFilesButton
            // 
            this.getFilesButton.Location = new System.Drawing.Point(12, 381);
            this.getFilesButton.Name = "getFilesButton";
            this.getFilesButton.Size = new System.Drawing.Size(75, 23);
            this.getFilesButton.TabIndex = 0;
            this.getFilesButton.Text = "Get Files";
            this.getFilesButton.UseVisualStyleBackColor = true;
            this.getFilesButton.Click += new System.EventHandler(this.getFilesButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 1;
            // 
            // generateFileButton
            // 
            this.generateFileButton.Location = new System.Drawing.Point(197, 381);
            this.generateFileButton.Name = "generateFileButton";
            this.generateFileButton.Size = new System.Drawing.Size(75, 23);
            this.generateFileButton.TabIndex = 2;
            this.generateFileButton.Text = "Generate";
            this.generateFileButton.UseVisualStyleBackColor = true;
            this.generateFileButton.Click += new System.EventHandler(this.generateFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 416);
            this.Controls.Add(this.generateFileButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.getFilesButton);
            this.Name = "Form1";
            this.Text = "CK2 Music File Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getFilesButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button generateFileButton;
    }
}

