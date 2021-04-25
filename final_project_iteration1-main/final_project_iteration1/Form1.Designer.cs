namespace final_project_iteration1
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
            this.uniTextBox = new System.Windows.Forms.TextBox();
            this.LOTRbutton = new System.Windows.Forms.RadioButton();
            this.GOTbutton = new System.Windows.Forms.RadioButton();
            this.Dunebutton = new System.Windows.Forms.RadioButton();
            this.goButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timelineCheckBox = new System.Windows.Forms.CheckBox();
            this.treeCheckBox = new System.Windows.Forms.CheckBox();
            this.itemCheckBox = new System.Windows.Forms.CheckBox();
            this.endButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uniTextBox
            // 
            this.uniTextBox.Location = new System.Drawing.Point(288, 64);
            this.uniTextBox.Name = "uniTextBox";
            this.uniTextBox.Size = new System.Drawing.Size(200, 20);
            this.uniTextBox.TabIndex = 0;
            this.uniTextBox.Text = "Which universe do you want to explore?";
            // 
            // LOTRbutton
            // 
            this.LOTRbutton.AutoSize = true;
            this.LOTRbutton.Location = new System.Drawing.Point(341, 101);
            this.LOTRbutton.Name = "LOTRbutton";
            this.LOTRbutton.Size = new System.Drawing.Size(106, 17);
            this.LOTRbutton.TabIndex = 1;
            this.LOTRbutton.TabStop = true;
            this.LOTRbutton.Text = "Lord of the Rings";
            this.LOTRbutton.UseVisualStyleBackColor = true;
            // 
            // GOTbutton
            // 
            this.GOTbutton.AutoSize = true;
            this.GOTbutton.Location = new System.Drawing.Point(341, 125);
            this.GOTbutton.Name = "GOTbutton";
            this.GOTbutton.Size = new System.Drawing.Size(107, 17);
            this.GOTbutton.TabIndex = 2;
            this.GOTbutton.TabStop = true;
            this.GOTbutton.Text = "Game of Thrones";
            this.GOTbutton.UseVisualStyleBackColor = true;
            // 
            // Dunebutton
            // 
            this.Dunebutton.AutoSize = true;
            this.Dunebutton.Location = new System.Drawing.Point(341, 149);
            this.Dunebutton.Name = "Dunebutton";
            this.Dunebutton.Size = new System.Drawing.Size(51, 17);
            this.Dunebutton.TabIndex = 3;
            this.Dunebutton.TabStop = true;
            this.Dunebutton.Text = "Dune";
            this.Dunebutton.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(341, 359);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 8;
            this.goButton.Text = "Dive!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Which page(s) do you want to go to?";
            // 
            // timelineCheckBox
            // 
            this.timelineCheckBox.AutoSize = true;
            this.timelineCheckBox.Location = new System.Drawing.Point(341, 259);
            this.timelineCheckBox.Name = "timelineCheckBox";
            this.timelineCheckBox.Size = new System.Drawing.Size(65, 17);
            this.timelineCheckBox.TabIndex = 10;
            this.timelineCheckBox.Text = "Timeline";
            this.timelineCheckBox.UseVisualStyleBackColor = true;
            // 
            // treeCheckBox
            // 
            this.treeCheckBox.AutoSize = true;
            this.treeCheckBox.Location = new System.Drawing.Point(341, 283);
            this.treeCheckBox.Name = "treeCheckBox";
            this.treeCheckBox.Size = new System.Drawing.Size(53, 17);
            this.treeCheckBox.TabIndex = 11;
            this.treeCheckBox.Text = "Trees";
            this.treeCheckBox.UseVisualStyleBackColor = true;
            // 
            // itemCheckBox
            // 
            this.itemCheckBox.AutoSize = true;
            this.itemCheckBox.Location = new System.Drawing.Point(341, 307);
            this.itemCheckBox.Name = "itemCheckBox";
            this.itemCheckBox.Size = new System.Drawing.Size(166, 17);
            this.itemCheckBox.TabIndex = 12;
            this.itemCheckBox.Text = "Create an Account/Character";
            this.itemCheckBox.UseVisualStyleBackColor = true;
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(713, 415);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 13;
            this.endButton.Text = "Close";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.itemCheckBox);
            this.Controls.Add(this.treeCheckBox);
            this.Controls.Add(this.timelineCheckBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.Dunebutton);
            this.Controls.Add(this.GOTbutton);
            this.Controls.Add(this.LOTRbutton);
            this.Controls.Add(this.uniTextBox);
            this.Name = "Form1";
            this.Text = "Start Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uniTextBox;
        private System.Windows.Forms.RadioButton LOTRbutton;
        private System.Windows.Forms.RadioButton GOTbutton;
        private System.Windows.Forms.RadioButton Dunebutton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox timelineCheckBox;
        private System.Windows.Forms.CheckBox treeCheckBox;
        private System.Windows.Forms.CheckBox itemCheckBox;
        private System.Windows.Forms.Button endButton;
    }
}

