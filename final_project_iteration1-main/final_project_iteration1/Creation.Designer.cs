namespace final_project_iteration1
{
    partial class Creation
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
            this.GOTRdBtn = new System.Windows.Forms.RadioButton();
            this.LOTRRdBtn = new System.Windows.Forms.RadioButton();
            this.DuneRdBtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BeginBtn = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GOTRdBtn
            // 
            this.GOTRdBtn.AutoSize = true;
            this.GOTRdBtn.Location = new System.Drawing.Point(217, 151);
            this.GOTRdBtn.Name = "GOTRdBtn";
            this.GOTRdBtn.Size = new System.Drawing.Size(107, 17);
            this.GOTRdBtn.TabIndex = 0;
            this.GOTRdBtn.TabStop = true;
            this.GOTRdBtn.Text = "Game of Thrones";
            this.GOTRdBtn.UseVisualStyleBackColor = true;
            // 
            // LOTRRdBtn
            // 
            this.LOTRRdBtn.AutoSize = true;
            this.LOTRRdBtn.Location = new System.Drawing.Point(442, 151);
            this.LOTRRdBtn.Name = "LOTRRdBtn";
            this.LOTRRdBtn.Size = new System.Drawing.Size(110, 17);
            this.LOTRRdBtn.TabIndex = 1;
            this.LOTRRdBtn.TabStop = true;
            this.LOTRRdBtn.Text = "Lord of The Rings";
            this.LOTRRdBtn.UseVisualStyleBackColor = true;
            // 
            // DuneRdBtn
            // 
            this.DuneRdBtn.AutoSize = true;
            this.DuneRdBtn.Location = new System.Drawing.Point(356, 151);
            this.DuneRdBtn.Name = "DuneRdBtn";
            this.DuneRdBtn.Size = new System.Drawing.Size(51, 17);
            this.DuneRdBtn.TabIndex = 2;
            this.DuneRdBtn.TabStop = true;
            this.DuneRdBtn.Text = "Dune";
            this.DuneRdBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(320, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Select Series";
            // 
            // BeginBtn
            // 
            this.BeginBtn.Location = new System.Drawing.Point(356, 258);
            this.BeginBtn.Name = "BeginBtn";
            this.BeginBtn.Size = new System.Drawing.Size(75, 39);
            this.BeginBtn.TabIndex = 4;
            this.BeginBtn.Text = "Begin!";
            this.BeginBtn.UseVisualStyleBackColor = true;
            this.BeginBtn.Click += new System.EventHandler(this.BeginBtn_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 415);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 27;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.BeginBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DuneRdBtn);
            this.Controls.Add(this.LOTRRdBtn);
            this.Controls.Add(this.GOTRdBtn);
            this.Name = "Creation";
            this.Text = "Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton GOTRdBtn;
        private System.Windows.Forms.RadioButton LOTRRdBtn;
        private System.Windows.Forms.RadioButton DuneRdBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BeginBtn;
        private System.Windows.Forms.Button returnButton;
    }
}