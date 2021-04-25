
namespace final_project_iteration1
{
    partial class DuneTree
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
            this.endButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.harkonnenButton = new System.Windows.Forms.Button();
            this.atreidesButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(511, 337);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 14;
            this.endButton.Text = "Close";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(11, 337);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // harkonnenButton
            // 
            this.harkonnenButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.harkonnenButton.Location = new System.Drawing.Point(290, 106);
            this.harkonnenButton.Name = "harkonnenButton";
            this.harkonnenButton.Size = new System.Drawing.Size(116, 33);
            this.harkonnenButton.TabIndex = 12;
            this.harkonnenButton.Text = "House Harkonnen";
            this.harkonnenButton.UseVisualStyleBackColor = false;
            this.harkonnenButton.Click += new System.EventHandler(this.harkonnenButton_Click);
            // 
            // atreidesButton
            // 
            this.atreidesButton.BackColor = System.Drawing.Color.Firebrick;
            this.atreidesButton.Location = new System.Drawing.Point(179, 106);
            this.atreidesButton.Name = "atreidesButton";
            this.atreidesButton.Size = new System.Drawing.Size(105, 33);
            this.atreidesButton.TabIndex = 11;
            this.atreidesButton.Text = "House Atreides";
            this.atreidesButton.UseVisualStyleBackColor = false;
            this.atreidesButton.Click += new System.EventHandler(this.atreidesButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Which tree would you like to look at?";
            // 
            // DuneTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.harkonnenButton);
            this.Controls.Add(this.atreidesButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DuneTree";
            this.Text = "Dune Family Trees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button harkonnenButton;
        private System.Windows.Forms.Button atreidesButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}