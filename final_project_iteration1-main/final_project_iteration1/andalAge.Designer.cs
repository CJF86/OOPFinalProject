﻿
namespace final_project_iteration1
{
    partial class andalAge
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
            this.eventBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.andalYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventBox
            // 
            this.eventBox.Location = new System.Drawing.Point(180, 162);
            this.eventBox.Multiline = true;
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(222, 117);
            this.eventBox.TabIndex = 24;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(286, 106);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 23;
            this.searchButton.Text = "Search Year";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // andalYear
            // 
            this.andalYear.Location = new System.Drawing.Point(218, 107);
            this.andalYear.Name = "andalYear";
            this.andalYear.Size = new System.Drawing.Size(47, 20);
            this.andalYear.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Year: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Please enter a date in the format: Year 8000BC - 2AC";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 331);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 26;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // andalAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.andalYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "andalAge";
            this.Text = "Andal and Doom Age";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox andalYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button returnButton;
    }
}