namespace final_project_iteration1
{
    partial class SignIn
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
            this.SignInBtn = new System.Windows.Forms.Button();
            this.UsrNameTxtBox = new System.Windows.Forms.TextBox();
            this.PassWrdTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(444, 160);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 37);
            this.SignInBtn.TabIndex = 0;
            this.SignInBtn.Text = "Sign In!";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // UsrNameTxtBox
            // 
            this.UsrNameTxtBox.Location = new System.Drawing.Point(285, 132);
            this.UsrNameTxtBox.Name = "UsrNameTxtBox";
            this.UsrNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UsrNameTxtBox.TabIndex = 1;
            // 
            // PassWrdTxtBox
            // 
            this.PassWrdTxtBox.Location = new System.Drawing.Point(285, 198);
            this.PassWrdTxtBox.Name = "PassWrdTxtBox";
            this.PassWrdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PassWrdTxtBox.TabIndex = 2;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassWrdTxtBox);
            this.Controls.Add(this.UsrNameTxtBox);
            this.Controls.Add(this.SignInBtn);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.TextBox UsrNameTxtBox;
        private System.Windows.Forms.TextBox PassWrdTxtBox;
    }
}