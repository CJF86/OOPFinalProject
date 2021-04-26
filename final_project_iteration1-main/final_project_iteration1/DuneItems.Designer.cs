
namespace final_project_iteration1
{
    partial class DuneItems
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
            this.TransportBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TransportPicBox = new System.Windows.Forms.PictureBox();
            this.FamilyPicBox = new System.Windows.Forms.PictureBox();
            this.TransportInfo = new System.Windows.Forms.TextBox();
            this.FamilyInfo = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransportPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TransportBox
            // 
            this.TransportBox.FormattingEnabled = true;
            this.TransportBox.Items.AddRange(new object[] {
            "Sand Worm",
            "Copter",
            "Spaceship"});
            this.TransportBox.Location = new System.Drawing.Point(12, 191);
            this.TransportBox.Name = "TransportBox";
            this.TransportBox.Size = new System.Drawing.Size(121, 21);
            this.TransportBox.TabIndex = 6;
            this.TransportBox.SelectedIndexChanged += new System.EventHandler(this.TransportBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Atreides",
            "Fremen",
            "Imperial",
            "Bene Gesserit"});
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TransportPicBox
            // 
            this.TransportPicBox.Location = new System.Drawing.Point(304, 191);
            this.TransportPicBox.Name = "TransportPicBox";
            this.TransportPicBox.Size = new System.Drawing.Size(137, 131);
            this.TransportPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TransportPicBox.TabIndex = 8;
            this.TransportPicBox.TabStop = false;
            // 
            // FamilyPicBox
            // 
            this.FamilyPicBox.Location = new System.Drawing.Point(304, 40);
            this.FamilyPicBox.Name = "FamilyPicBox";
            this.FamilyPicBox.Size = new System.Drawing.Size(137, 131);
            this.FamilyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FamilyPicBox.TabIndex = 9;
            this.FamilyPicBox.TabStop = false;
            // 
            // TransportInfo
            // 
            this.TransportInfo.Location = new System.Drawing.Point(453, 191);
            this.TransportInfo.Multiline = true;
            this.TransportInfo.Name = "TransportInfo";
            this.TransportInfo.ReadOnly = true;
            this.TransportInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransportInfo.Size = new System.Drawing.Size(135, 131);
            this.TransportInfo.TabIndex = 10;
            // 
            // FamilyInfo
            // 
            this.FamilyInfo.Location = new System.Drawing.Point(453, 39);
            this.FamilyInfo.Multiline = true;
            this.FamilyInfo.Name = "FamilyInfo";
            this.FamilyInfo.ReadOnly = true;
            this.FamilyInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FamilyInfo.Size = new System.Drawing.Size(135, 131);
            this.FamilyInfo.TabIndex = 11;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 331);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 27;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Choose a house";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Choose a vehicle";
            // 
            // DuneItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.FamilyInfo);
            this.Controls.Add(this.TransportInfo);
            this.Controls.Add(this.FamilyPicBox);
            this.Controls.Add(this.TransportPicBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TransportBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DuneItems";
            this.Text = "Dune Items";
            ((System.ComponentModel.ISupportInitialize)(this.TransportPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TransportBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox TransportPicBox;
        private System.Windows.Forms.PictureBox FamilyPicBox;
        private System.Windows.Forms.TextBox TransportInfo;
        private System.Windows.Forms.TextBox FamilyInfo;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}