
namespace final_project_iteration1
{
    partial class DuneTimeline
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
            this.titanButton = new System.Windows.Forms.RadioButton();
            this.omniusButton = new System.Windows.Forms.RadioButton();
            this.elroodButton = new System.Windows.Forms.RadioButton();
            this.shaddamButton = new System.Windows.Forms.RadioButton();
            this.paulButton = new System.Windows.Forms.RadioButton();
            this.scatterButton = new System.Windows.Forms.RadioButton();
            this.surfButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "What age?";
            // 
            // titanButton
            // 
            this.titanButton.AutoSize = true;
            this.titanButton.Location = new System.Drawing.Point(166, 110);
            this.titanButton.Name = "titanButton";
            this.titanButton.Size = new System.Drawing.Size(134, 17);
            this.titanButton.TabIndex = 2;
            this.titanButton.TabStop = true;
            this.titanButton.Text = "B.G and Time of Titans";
            this.titanButton.UseVisualStyleBackColor = true;
            // 
            // omniusButton
            // 
            this.omniusButton.AutoSize = true;
            this.omniusButton.Location = new System.Drawing.Point(307, 111);
            this.omniusButton.Name = "omniusButton";
            this.omniusButton.Size = new System.Drawing.Size(96, 17);
            this.omniusButton.TabIndex = 3;
            this.omniusButton.TabStop = true;
            this.omniusButton.Text = "Birth of Omnius";
            this.omniusButton.UseVisualStyleBackColor = true;
            // 
            // elroodButton
            // 
            this.elroodButton.AutoSize = true;
            this.elroodButton.Location = new System.Drawing.Point(166, 134);
            this.elroodButton.Name = "elroodButton";
            this.elroodButton.Size = new System.Drawing.Size(83, 17);
            this.elroodButton.TabIndex = 4;
            this.elroodButton.TabStop = true;
            this.elroodButton.Text = "ELROOD IX";
            this.elroodButton.UseVisualStyleBackColor = true;
            // 
            // shaddamButton
            // 
            this.shaddamButton.AutoSize = true;
            this.shaddamButton.Location = new System.Drawing.Point(307, 134);
            this.shaddamButton.Name = "shaddamButton";
            this.shaddamButton.Size = new System.Drawing.Size(92, 17);
            this.shaddamButton.TabIndex = 5;
            this.shaddamButton.TabStop = true;
            this.shaddamButton.Text = "SHADDAM IV";
            this.shaddamButton.UseVisualStyleBackColor = true;
            // 
            // paulButton
            // 
            this.paulButton.AutoSize = true;
            this.paulButton.Location = new System.Drawing.Point(167, 157);
            this.paulButton.Name = "paulButton";
            this.paulButton.Size = new System.Drawing.Size(133, 17);
            this.paulButton.TabIndex = 6;
            this.paulButton.TabStop = true;
            this.paulButton.Text = "Rise of House Atreides";
            this.paulButton.UseVisualStyleBackColor = true;
            // 
            // scatterButton
            // 
            this.scatterButton.AutoSize = true;
            this.scatterButton.Location = new System.Drawing.Point(306, 157);
            this.scatterButton.Name = "scatterButton";
            this.scatterButton.Size = new System.Drawing.Size(95, 17);
            this.scatterButton.TabIndex = 7;
            this.scatterButton.TabStop = true;
            this.scatterButton.Text = "The Scattering";
            this.scatterButton.UseVisualStyleBackColor = true;
            // 
            // surfButton
            // 
            this.surfButton.Location = new System.Drawing.Point(243, 201);
            this.surfButton.Name = "surfButton";
            this.surfButton.Size = new System.Drawing.Size(86, 23);
            this.surfButton.TabIndex = 8;
            this.surfButton.Text = "Surf the Dune";
            this.surfButton.UseVisualStyleBackColor = true;
            this.surfButton.Click += new System.EventHandler(this.surfButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(13, 331);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "<- Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(513, 331);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 10;
            this.endButton.Text = "Close";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // DuneTimeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.surfButton);
            this.Controls.Add(this.scatterButton);
            this.Controls.Add(this.paulButton);
            this.Controls.Add(this.shaddamButton);
            this.Controls.Add(this.elroodButton);
            this.Controls.Add(this.omniusButton);
            this.Controls.Add(this.titanButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DuneTimeline";
            this.Text = "Dune Timelines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton titanButton;
        private System.Windows.Forms.RadioButton omniusButton;
        private System.Windows.Forms.RadioButton elroodButton;
        private System.Windows.Forms.RadioButton shaddamButton;
        private System.Windows.Forms.RadioButton paulButton;
        private System.Windows.Forms.RadioButton scatterButton;
        private System.Windows.Forms.Button surfButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button endButton;
    }
}