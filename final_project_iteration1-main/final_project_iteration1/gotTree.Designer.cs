
namespace final_project_iteration1
{
    partial class gotTree
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
            this.starkButton = new System.Windows.Forms.Button();
            this.lannisterButton = new System.Windows.Forms.Button();
            this.targaryenButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Which tree would you like to look at?";
            // 
            // starkButton
            // 
            this.starkButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.starkButton.Location = new System.Drawing.Point(254, 101);
            this.starkButton.Name = "starkButton";
            this.starkButton.Size = new System.Drawing.Size(75, 33);
            this.starkButton.TabIndex = 1;
            this.starkButton.Text = "House Stark";
            this.starkButton.UseVisualStyleBackColor = false;
            this.starkButton.Click += new System.EventHandler(this.starkButton_Click);
            // 
            // lannisterButton
            // 
            this.lannisterButton.BackColor = System.Drawing.Color.Yellow;
            this.lannisterButton.Location = new System.Drawing.Point(143, 101);
            this.lannisterButton.Name = "lannisterButton";
            this.lannisterButton.Size = new System.Drawing.Size(105, 33);
            this.lannisterButton.TabIndex = 2;
            this.lannisterButton.Text = "House Lannister";
            this.lannisterButton.UseVisualStyleBackColor = false;
            this.lannisterButton.Click += new System.EventHandler(this.lannisterButton_Click);
            // 
            // targaryenButton
            // 
            this.targaryenButton.BackColor = System.Drawing.Color.DarkRed;
            this.targaryenButton.Location = new System.Drawing.Point(335, 101);
            this.targaryenButton.Name = "targaryenButton";
            this.targaryenButton.Size = new System.Drawing.Size(116, 33);
            this.targaryenButton.TabIndex = 6;
            this.targaryenButton.Text = "House Targaryen";
            this.targaryenButton.UseVisualStyleBackColor = false;
            this.targaryenButton.Click += new System.EventHandler(this.targaryenButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 331);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(513, 331);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 8;
            this.endButton.Text = "Close";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // gotTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.targaryenButton);
            this.Controls.Add(this.lannisterButton);
            this.Controls.Add(this.starkButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "gotTree";
            this.Text = "Game of Thrones Family Trees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button starkButton;
        private System.Windows.Forms.Button lannisterButton;
        private System.Windows.Forms.Button targaryenButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button endButton;
    }
}