
namespace final_project_iteration1
{
    partial class gotTimeline
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
            this.dawnButton = new System.Windows.Forms.RadioButton();
            this.andalButton = new System.Windows.Forms.RadioButton();
            this.hundredButton = new System.Windows.Forms.RadioButton();
            this.conquestButton = new System.Windows.Forms.RadioButton();
            this.postButton = new System.Windows.Forms.RadioButton();
            this.lotrTimeButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Pick an era:";
            // 
            // dawnButton
            // 
            this.dawnButton.AutoSize = true;
            this.dawnButton.Location = new System.Drawing.Point(230, 113);
            this.dawnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dawnButton.Name = "dawnButton";
            this.dawnButton.Size = new System.Drawing.Size(122, 17);
            this.dawnButton.TabIndex = 1;
            this.dawnButton.TabStop = true;
            this.dawnButton.Text = "Dawn and Hero Age";
            this.dawnButton.UseVisualStyleBackColor = true;
            // 
            // andalButton
            // 
            this.andalButton.AutoSize = true;
            this.andalButton.Location = new System.Drawing.Point(230, 135);
            this.andalButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.andalButton.Name = "andalButton";
            this.andalButton.Size = new System.Drawing.Size(193, 17);
            this.andalButton.TabIndex = 3;
            this.andalButton.TabStop = true;
            this.andalButton.Text = "Andal Invasion and Doom of Valyria";
            this.andalButton.UseVisualStyleBackColor = true;
            // 
            // hundredButton
            // 
            this.hundredButton.AutoSize = true;
            this.hundredButton.Location = new System.Drawing.Point(230, 157);
            this.hundredButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hundredButton.Name = "hundredButton";
            this.hundredButton.Size = new System.Drawing.Size(137, 17);
            this.hundredButton.TabIndex = 5;
            this.hundredButton.TabStop = true;
            this.hundredButton.Text = "Hundred Kingdoms Age";
            this.hundredButton.UseVisualStyleBackColor = true;
            // 
            // conquestButton
            // 
            this.conquestButton.AutoSize = true;
            this.conquestButton.Location = new System.Drawing.Point(230, 179);
            this.conquestButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conquestButton.Name = "conquestButton";
            this.conquestButton.Size = new System.Drawing.Size(195, 17);
            this.conquestButton.TabIndex = 6;
            this.conquestButton.TabStop = true;
            this.conquestButton.Text = "The Conquest and Targaryen Reign";
            this.conquestButton.UseVisualStyleBackColor = true;
            // 
            // postButton
            // 
            this.postButton.AutoSize = true;
            this.postButton.Location = new System.Drawing.Point(230, 201);
            this.postButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(128, 17);
            this.postButton.TabIndex = 8;
            this.postButton.TabStop = true;
            this.postButton.Text = "Post-Targeryen Reign";
            this.postButton.UseVisualStyleBackColor = true;
            // 
            // lotrTimeButton
            // 
            this.lotrTimeButton.Location = new System.Drawing.Point(256, 231);
            this.lotrTimeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lotrTimeButton.Name = "lotrTimeButton";
            this.lotrTimeButton.Size = new System.Drawing.Size(56, 19);
            this.lotrTimeButton.TabIndex = 9;
            this.lotrTimeButton.Text = "88 MPH";
            this.lotrTimeButton.UseVisualStyleBackColor = true;
            this.lotrTimeButton.Click += new System.EventHandler(this.lotrTimeButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(13, 331);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "<- Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(513, 331);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 11;
            this.endButton.Text = "Close";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // gotTimeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.lotrTimeButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.conquestButton);
            this.Controls.Add(this.hundredButton);
            this.Controls.Add(this.andalButton);
            this.Controls.Add(this.dawnButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gotTimeline";
            this.Text = "Game of Thrones Timelines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton dawnButton;
        private System.Windows.Forms.RadioButton andalButton;
        private System.Windows.Forms.RadioButton hundredButton;
        private System.Windows.Forms.RadioButton conquestButton;
        private System.Windows.Forms.RadioButton postButton;
        private System.Windows.Forms.Button lotrTimeButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button endButton;
    }
}