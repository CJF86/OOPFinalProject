
namespace final_project_iteration1
{
    partial class gotItem
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
            this.SigilPicBox = new System.Windows.Forms.PictureBox();
            this.InfoTxtBox = new System.Windows.Forms.TextBox();
            this.HouseBox = new System.Windows.Forms.ComboBox();
            this.AnimalPicBox = new System.Windows.Forms.PictureBox();
            this.AnimalInfo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnimalBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SigilPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SigilPicBox
            // 
            this.SigilPicBox.Location = new System.Drawing.Point(306, 34);
            this.SigilPicBox.Name = "SigilPicBox";
            this.SigilPicBox.Size = new System.Drawing.Size(137, 131);
            this.SigilPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SigilPicBox.TabIndex = 0;
            this.SigilPicBox.TabStop = false;
            // 
            // InfoTxtBox
            // 
            this.InfoTxtBox.Location = new System.Drawing.Point(453, 34);
            this.InfoTxtBox.Multiline = true;
            this.InfoTxtBox.Name = "InfoTxtBox";
            this.InfoTxtBox.ReadOnly = true;
            this.InfoTxtBox.Size = new System.Drawing.Size(135, 131);
            this.InfoTxtBox.TabIndex = 1;
            // 
            // HouseBox
            // 
            this.HouseBox.FormattingEnabled = true;
            this.HouseBox.Items.AddRange(new object[] {
            "Targaryen",
            "Stark",
            "Baratheon",
            "Lannister",
            "GreyJoy",
            "Martell",
            "Tyrell"});
            this.HouseBox.Location = new System.Drawing.Point(12, 34);
            this.HouseBox.Name = "HouseBox";
            this.HouseBox.Size = new System.Drawing.Size(121, 21);
            this.HouseBox.TabIndex = 2;
            this.HouseBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AnimalPicBox
            // 
            this.AnimalPicBox.Location = new System.Drawing.Point(306, 188);
            this.AnimalPicBox.Name = "AnimalPicBox";
            this.AnimalPicBox.Size = new System.Drawing.Size(137, 145);
            this.AnimalPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnimalPicBox.TabIndex = 3;
            this.AnimalPicBox.TabStop = false;
            // 
            // AnimalInfo
            // 
            this.AnimalInfo.Location = new System.Drawing.Point(453, 188);
            this.AnimalInfo.Multiline = true;
            this.AnimalInfo.Name = "AnimalInfo";
            this.AnimalInfo.ReadOnly = true;
            this.AnimalInfo.Size = new System.Drawing.Size(135, 145);
            this.AnimalInfo.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 327);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 27);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Name Here";
            // 
            // AnimalBox
            // 
            this.AnimalBox.FormattingEnabled = true;
            this.AnimalBox.Items.AddRange(new object[] {
            "Drogon",
            "Viserion",
            "Rhaegol",
            "Grey Wind",
            "Lady",
            "Nymeria",
            "Summer",
            "Shaggydog",
            "Ghost"});
            this.AnimalBox.Location = new System.Drawing.Point(15, 188);
            this.AnimalBox.Name = "AnimalBox";
            this.AnimalBox.Size = new System.Drawing.Size(128, 21);
            this.AnimalBox.TabIndex = 7;
            this.AnimalBox.SelectedIndexChanged += new System.EventHandler(this.AnimalBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select a companion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select a house";
            // 
            // gotItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnimalBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AnimalInfo);
            this.Controls.Add(this.AnimalPicBox);
            this.Controls.Add(this.HouseBox);
            this.Controls.Add(this.InfoTxtBox);
            this.Controls.Add(this.SigilPicBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "gotItem";
            this.Text = "Game of Thrones Items";
            ((System.ComponentModel.ISupportInitialize)(this.SigilPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SigilPicBox;
        private System.Windows.Forms.TextBox InfoTxtBox;
        private System.Windows.Forms.ComboBox HouseBox;
        private System.Windows.Forms.PictureBox AnimalPicBox;
        private System.Windows.Forms.TextBox AnimalInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AnimalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}