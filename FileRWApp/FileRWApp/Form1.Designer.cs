namespace FileRWApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerInfoTextBox = new System.Windows.Forms.TextBox();
            this.showAllListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Info";
            // 
            // customerInfoTextBox
            // 
            this.customerInfoTextBox.Location = new System.Drawing.Point(91, 26);
            this.customerInfoTextBox.Name = "customerInfoTextBox";
            this.customerInfoTextBox.Size = new System.Drawing.Size(120, 20);
            this.customerInfoTextBox.TabIndex = 1;
            // 
            // showAllListBox
            // 
            this.showAllListBox.FormattingEnabled = true;
            this.showAllListBox.Location = new System.Drawing.Point(82, 90);
            this.showAllListBox.Name = "showAllListBox";
            this.showAllListBox.Size = new System.Drawing.Size(120, 95);
            this.showAllListBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(227, 21);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(227, 90);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 4;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 260);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showAllListBox);
            this.Controls.Add(this.customerInfoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerInfoTextBox;
        private System.Windows.Forms.ListBox showAllListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllButton;
    }
}

