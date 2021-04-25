namespace final_project_iteration1
{
    partial class SignUp
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
            this.CreatePassTxtBox = new System.Windows.Forms.TextBox();
            this.CreateUserTxtBox = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePassTxtBox
            // 
            this.CreatePassTxtBox.Location = new System.Drawing.Point(242, 260);
            this.CreatePassTxtBox.Name = "CreatePassTxtBox";
            this.CreatePassTxtBox.Size = new System.Drawing.Size(100, 20);
            this.CreatePassTxtBox.TabIndex = 0;
            // 
            // CreateUserTxtBox
            // 
            this.CreateUserTxtBox.Location = new System.Drawing.Point(242, 185);
            this.CreateUserTxtBox.Name = "CreateUserTxtBox";
            this.CreateUserTxtBox.Size = new System.Drawing.Size(100, 20);
            this.CreateUserTxtBox.TabIndex = 1;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(450, 209);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 35);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create Account!";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.CreateUserTxtBox);
            this.Controls.Add(this.CreatePassTxtBox);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CreatePassTxtBox;
        private System.Windows.Forms.TextBox CreateUserTxtBox;
        private System.Windows.Forms.Button CreateBtn;
    }
}