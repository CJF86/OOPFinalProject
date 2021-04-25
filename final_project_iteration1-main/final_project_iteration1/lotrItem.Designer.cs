namespace final_project_iteration1
{
    partial class lotrItem
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
            this.RealmPicBox = new System.Windows.Forms.PictureBox();
            this.RacePicBox = new System.Windows.Forms.PictureBox();
            this.RealmInfo = new System.Windows.Forms.TextBox();
            this.RaceInfo = new System.Windows.Forms.TextBox();
            this.RaceBox = new System.Windows.Forms.ComboBox();
            this.RealmBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RealmPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RacePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RealmPicBox
            // 
            this.RealmPicBox.Location = new System.Drawing.Point(297, 192);
            this.RealmPicBox.Name = "RealmPicBox";
            this.RealmPicBox.Size = new System.Drawing.Size(137, 139);
            this.RealmPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RealmPicBox.TabIndex = 1;
            this.RealmPicBox.TabStop = false;
            // 
            // RacePicBox
            // 
            this.RacePicBox.Location = new System.Drawing.Point(297, 24);
            this.RacePicBox.Name = "RacePicBox";
            this.RacePicBox.Size = new System.Drawing.Size(137, 131);
            this.RacePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RacePicBox.TabIndex = 2;
            this.RacePicBox.TabStop = false;
            // 
            // RealmInfo
            // 
            this.RealmInfo.Location = new System.Drawing.Point(453, 192);
            this.RealmInfo.Multiline = true;
            this.RealmInfo.Name = "RealmInfo";
            this.RealmInfo.ReadOnly = true;
            this.RealmInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RealmInfo.Size = new System.Drawing.Size(135, 139);
            this.RealmInfo.TabIndex = 3;
            // 
            // RaceInfo
            // 
            this.RaceInfo.Location = new System.Drawing.Point(453, 24);
            this.RaceInfo.Multiline = true;
            this.RaceInfo.Name = "RaceInfo";
            this.RaceInfo.ReadOnly = true;
            this.RaceInfo.Size = new System.Drawing.Size(135, 131);
            this.RaceInfo.TabIndex = 4;
            // 
            // RaceBox
            // 
            this.RaceBox.FormattingEnabled = true;
            this.RaceBox.Items.AddRange(new object[] {
            "Men",
            "Elves",
            "Hobbits",
            "Dwarves"});
            this.RaceBox.Location = new System.Drawing.Point(12, 24);
            this.RaceBox.Name = "RaceBox";
            this.RaceBox.Size = new System.Drawing.Size(121, 21);
            this.RaceBox.TabIndex = 5;
            this.RaceBox.SelectedIndexChanged += new System.EventHandler(this.RaceBox_SelectedIndexChanged);
            // 
            // RealmBox
            // 
            this.RealmBox.FormattingEnabled = true;
            this.RealmBox.Items.AddRange(new object[] {
            "Gondor",
            "Rohan",
            "Mirkwood",
            "Lothlorien",
            "The Shire"});
            this.RealmBox.Location = new System.Drawing.Point(12, 192);
            this.RealmBox.Name = "RealmBox";
            this.RealmBox.Size = new System.Drawing.Size(121, 21);
            this.RealmBox.TabIndex = 6;
            this.RealmBox.SelectedIndexChanged += new System.EventHandler(this.RealmBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 311);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a race";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select a realm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Create a name";
            // 
            // lotrItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RealmBox);
            this.Controls.Add(this.RaceBox);
            this.Controls.Add(this.RaceInfo);
            this.Controls.Add(this.RealmInfo);
            this.Controls.Add(this.RacePicBox);
            this.Controls.Add(this.RealmPicBox);
            this.Name = "lotrItem";
            this.Text = "LOTR lore items";
            this.Load += new System.EventHandler(this.lotrItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RealmPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RacePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RealmPicBox;
        private System.Windows.Forms.PictureBox RacePicBox;
        private System.Windows.Forms.TextBox RealmInfo;
        private System.Windows.Forms.TextBox RaceInfo;
        private System.Windows.Forms.ComboBox RaceBox;
        private System.Windows.Forms.ComboBox RealmBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}