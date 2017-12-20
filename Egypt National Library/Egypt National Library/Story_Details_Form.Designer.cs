namespace Egypt_National_Library
{
    partial class Story_Details_Form
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
            this.SectionNameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StoryNameLabel = new System.Windows.Forms.Label();
            this.Story_ImagePicturebox = new System.Windows.Forms.PictureBox();
            this.Return = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.RateBtn = new System.Windows.Forms.Button();
            this.VeryPoor = new System.Windows.Forms.RadioButton();
            this.Poor = new System.Windows.Forms.RadioButton();
            this.Good = new System.Windows.Forms.RadioButton();
            this.VeryGood = new System.Windows.Forms.RadioButton();
            this.Excellent = new System.Windows.Forms.RadioButton();
            this.InUse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Story_ImagePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionNameLabel
            // 
            this.SectionNameLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.SectionNameLabel.Location = new System.Drawing.Point(555, 82);
            this.SectionNameLabel.Name = "SectionNameLabel";
            this.SectionNameLabel.Size = new System.Drawing.Size(206, 35);
            this.SectionNameLabel.TabIndex = 32;
            this.SectionNameLabel.Text = "Section Name";
            this.SectionNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.PriceLabel.Location = new System.Drawing.Point(555, 33);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(206, 35);
            this.PriceLabel.TabIndex = 30;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(360, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Section Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(360, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(371, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 20;
            // 
            // StoryNameLabel
            // 
            this.StoryNameLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.StoryNameLabel.Location = new System.Drawing.Point(49, 449);
            this.StoryNameLabel.Name = "StoryNameLabel";
            this.StoryNameLabel.Size = new System.Drawing.Size(287, 98);
            this.StoryNameLabel.TabIndex = 19;
            this.StoryNameLabel.Text = "Story Name";
            this.StoryNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Story_ImagePicturebox
            // 
            this.Story_ImagePicturebox.Location = new System.Drawing.Point(49, 12);
            this.Story_ImagePicturebox.Name = "Story_ImagePicturebox";
            this.Story_ImagePicturebox.Size = new System.Drawing.Size(287, 402);
            this.Story_ImagePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Story_ImagePicturebox.TabIndex = 18;
            this.Story_ImagePicturebox.TabStop = false;
            // 
            // Return
            // 
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Location = new System.Drawing.Point(738, 502);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(80, 38);
            this.Return.TabIndex = 33;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 552);
            this.panel1.TabIndex = 34;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.Enabled = false;
            this.BorrowBtn.Location = new System.Drawing.Point(364, 148);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(120, 43);
            this.BorrowBtn.TabIndex = 35;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = true;
            this.BorrowBtn.Visible = false;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click_1);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Enabled = false;
            this.ReturnBtn.Location = new System.Drawing.Point(611, 148);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(120, 43);
            this.ReturnBtn.TabIndex = 36;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Visible = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click_1);
            // 
            // RateBtn
            // 
            this.RateBtn.Location = new System.Drawing.Point(611, 266);
            this.RateBtn.Name = "RateBtn";
            this.RateBtn.Size = new System.Drawing.Size(120, 43);
            this.RateBtn.TabIndex = 37;
            this.RateBtn.Text = "Rate it!";
            this.RateBtn.UseVisualStyleBackColor = true;
            this.RateBtn.Click += new System.EventHandler(this.RateBtn_Click);
            // 
            // VeryPoor
            // 
            this.VeryPoor.AutoSize = true;
            this.VeryPoor.Location = new System.Drawing.Point(355, 234);
            this.VeryPoor.Name = "VeryPoor";
            this.VeryPoor.Size = new System.Drawing.Size(138, 32);
            this.VeryPoor.TabIndex = 38;
            this.VeryPoor.TabStop = true;
            this.VeryPoor.Text = "VeryPoor";
            this.VeryPoor.UseVisualStyleBackColor = true;
            // 
            // Poor
            // 
            this.Poor.AutoSize = true;
            this.Poor.Location = new System.Drawing.Point(355, 266);
            this.Poor.Name = "Poor";
            this.Poor.Size = new System.Drawing.Size(84, 32);
            this.Poor.TabIndex = 39;
            this.Poor.TabStop = true;
            this.Poor.Text = "Poor";
            this.Poor.UseVisualStyleBackColor = true;
            // 
            // Good
            // 
            this.Good.AutoSize = true;
            this.Good.Location = new System.Drawing.Point(355, 299);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(99, 32);
            this.Good.TabIndex = 40;
            this.Good.TabStop = true;
            this.Good.Text = "Good";
            this.Good.UseVisualStyleBackColor = true;
            // 
            // VeryGood
            // 
            this.VeryGood.AutoSize = true;
            this.VeryGood.Location = new System.Drawing.Point(355, 332);
            this.VeryGood.Name = "VeryGood";
            this.VeryGood.Size = new System.Drawing.Size(153, 32);
            this.VeryGood.TabIndex = 41;
            this.VeryGood.TabStop = true;
            this.VeryGood.Text = "VeryGood";
            this.VeryGood.UseVisualStyleBackColor = true;
            // 
            // Excellent
            // 
            this.Excellent.AutoSize = true;
            this.Excellent.Location = new System.Drawing.Point(355, 365);
            this.Excellent.Name = "Excellent";
            this.Excellent.Size = new System.Drawing.Size(136, 32);
            this.Excellent.TabIndex = 42;
            this.Excellent.TabStop = true;
            this.Excellent.Text = "Excellent";
            this.Excellent.UseVisualStyleBackColor = true;
            // 
            // InUse
            // 
            this.InUse.AutoSize = true;
            this.InUse.Location = new System.Drawing.Point(506, 163);
            this.InUse.Name = "InUse";
            this.InUse.Size = new System.Drawing.Size(74, 28);
            this.InUse.TabIndex = 43;
            this.InUse.Text = "InUse";
            this.InUse.Visible = false;
            // 
            // Story_Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 552);
            this.Controls.Add(this.InUse);
            this.Controls.Add(this.Excellent);
            this.Controls.Add(this.VeryGood);
            this.Controls.Add(this.Good);
            this.Controls.Add(this.Poor);
            this.Controls.Add(this.VeryPoor);
            this.Controls.Add(this.RateBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.BorrowBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.SectionNameLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoryNameLabel);
            this.Controls.Add(this.Story_ImagePicturebox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSalmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Story_Details_Form";
            this.Text = "Story_Details_Form";
            this.Load += new System.EventHandler(this.Story_Details_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Story_ImagePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SectionNameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StoryNameLabel;
        private System.Windows.Forms.PictureBox Story_ImagePicturebox;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button RateBtn;
        private System.Windows.Forms.RadioButton VeryPoor;
        private System.Windows.Forms.RadioButton Poor;
        private System.Windows.Forms.RadioButton Good;
        private System.Windows.Forms.RadioButton VeryGood;
        private System.Windows.Forms.RadioButton Excellent;
        private System.Windows.Forms.Label InUse;
    }
}