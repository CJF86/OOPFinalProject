namespace final_project_iteration1
{
    partial class lotrTimeline
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstAgeButton = new System.Windows.Forms.RadioButton();
            this.secondAgeButton = new System.Windows.Forms.RadioButton();
            this.thirdAgeButton = new System.Windows.Forms.RadioButton();
            this.flyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "What age?";
            // 
            // firstAgeButton
            // 
            this.firstAgeButton.AutoSize = true;
            this.firstAgeButton.Location = new System.Drawing.Point(281, 159);
            this.firstAgeButton.Name = "firstAgeButton";
            this.firstAgeButton.Size = new System.Drawing.Size(61, 17);
            this.firstAgeButton.TabIndex = 1;
            this.firstAgeButton.TabStop = true;
            this.firstAgeButton.Text = "1st Age";
            this.firstAgeButton.UseVisualStyleBackColor = true;
            // 
            // secondAgeButton
            // 
            this.secondAgeButton.AutoSize = true;
            this.secondAgeButton.Location = new System.Drawing.Point(348, 159);
            this.secondAgeButton.Name = "secondAgeButton";
            this.secondAgeButton.Size = new System.Drawing.Size(65, 17);
            this.secondAgeButton.TabIndex = 2;
            this.secondAgeButton.TabStop = true;
            this.secondAgeButton.Text = "2nd Age";
            this.secondAgeButton.UseVisualStyleBackColor = true;
            // 
            // thirdAgeButton
            // 
            this.thirdAgeButton.AutoSize = true;
            this.thirdAgeButton.Location = new System.Drawing.Point(419, 159);
            this.thirdAgeButton.Name = "thirdAgeButton";
            this.thirdAgeButton.Size = new System.Drawing.Size(62, 17);
            this.thirdAgeButton.TabIndex = 3;
            this.thirdAgeButton.TabStop = true;
            this.thirdAgeButton.Text = "3rd Age";
            this.thirdAgeButton.UseVisualStyleBackColor = true;
            // 
            // flyButton
            // 
            this.flyButton.Location = new System.Drawing.Point(334, 212);
            this.flyButton.Name = "flyButton";
            this.flyButton.Size = new System.Drawing.Size(93, 23);
            this.flyButton.TabIndex = 4;
            this.flyButton.Text = "Fly, you fools!";
            this.flyButton.UseVisualStyleBackColor = true;
            this.flyButton.Click += new System.EventHandler(this.flyButton_Click);
            // 
            // lotrTimeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flyButton);
            this.Controls.Add(this.thirdAgeButton);
            this.Controls.Add(this.secondAgeButton);
            this.Controls.Add(this.firstAgeButton);
            this.Controls.Add(this.textBox1);
            this.Name = "lotrTimeline";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton firstAgeButton;
        private System.Windows.Forms.RadioButton secondAgeButton;
        private System.Windows.Forms.RadioButton thirdAgeButton;
        private System.Windows.Forms.Button flyButton;
    }
}