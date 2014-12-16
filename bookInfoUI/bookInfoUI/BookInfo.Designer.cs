namespace bookInfoUI
{
    partial class BookInfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ISBNSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookDetailsSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBNAddTextBox = new System.Windows.Forms.TextBox();
            this.bookDetailsAddTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Details";
            // 
            // ISBNSearchTextBox
            // 
            this.ISBNSearchTextBox.Location = new System.Drawing.Point(125, 186);
            this.ISBNSearchTextBox.Name = "ISBNSearchTextBox";
            this.ISBNSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNSearchTextBox.TabIndex = 2;
            // 
            // bookDetailsSearchTextBox
            // 
            this.bookDetailsSearchTextBox.Location = new System.Drawing.Point(125, 217);
            this.bookDetailsSearchTextBox.Name = "bookDetailsSearchTextBox";
            this.bookDetailsSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookDetailsSearchTextBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(240, 215);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ISBN";
            // 
            // ISBNAddTextBox
            // 
            this.ISBNAddTextBox.Location = new System.Drawing.Point(125, 58);
            this.ISBNAddTextBox.Name = "ISBNAddTextBox";
            this.ISBNAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNAddTextBox.TabIndex = 2;
            // 
            // bookDetailsAddTextBox
            // 
            this.bookDetailsAddTextBox.Location = new System.Drawing.Point(125, 89);
            this.bookDetailsAddTextBox.Name = "bookDetailsAddTextBox";
            this.bookDetailsAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookDetailsAddTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(240, 87);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Add Book Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search Book";
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.bookDetailsAddTextBox);
            this.Controls.Add(this.bookDetailsSearchTextBox);
            this.Controls.Add(this.ISBNAddTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ISBNSearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "BookInfo";
            this.Text = "BookInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ISBNSearchTextBox;
        private System.Windows.Forms.TextBox bookDetailsSearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ISBNAddTextBox;
        private System.Windows.Forms.TextBox bookDetailsAddTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

