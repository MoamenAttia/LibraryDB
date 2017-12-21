namespace Egypt_National_Library
{
    partial class Music_Instrument_Details_Form
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
            this.Return = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SectionNameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Music_Name = new System.Windows.Forms.Label();
            this.MusicIns_ImagePicturebox = new System.Windows.Forms.PictureBox();
            this.ReserveBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.RateBtn = new System.Windows.Forms.Button();
            this.InUse = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            this.VeryPoor = new System.Windows.Forms.RadioButton();
            this.Poor = new System.Windows.Forms.RadioButton();
            this.Good = new System.Windows.Forms.RadioButton();
            this.VeryGood = new System.Windows.Forms.RadioButton();
            this.Excellent = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MusicIns_ImagePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.FlatAppearance.BorderSize = 2;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Return.Location = new System.Drawing.Point(628, 591);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(80, 36);
            this.Return.TabIndex = 39;
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
            this.panel1.Size = new System.Drawing.Size(20, 639);
            this.panel1.TabIndex = 38;
            // 
            // SectionNameLabel
            // 
            this.SectionNameLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.SectionNameLabel.Location = new System.Drawing.Point(530, 109);
            this.SectionNameLabel.Name = "SectionNameLabel";
            this.SectionNameLabel.Size = new System.Drawing.Size(153, 35);
            this.SectionNameLabel.TabIndex = 34;
            this.SectionNameLabel.Text = "Section Name";
            this.SectionNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.PriceLabel.Location = new System.Drawing.Point(530, 58);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(153, 35);
            this.PriceLabel.TabIndex = 32;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(356, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Section Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(356, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Price";
            // 
            // Music_Name
            // 
            this.Music_Name.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Music_Name.Location = new System.Drawing.Point(35, 446);
            this.Music_Name.Name = "Music_Name";
            this.Music_Name.Size = new System.Drawing.Size(287, 98);
            this.Music_Name.TabIndex = 21;
            this.Music_Name.Text = "Music Ins Name";
            this.Music_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MusicIns_ImagePicturebox
            // 
            this.MusicIns_ImagePicturebox.Location = new System.Drawing.Point(35, 12);
            this.MusicIns_ImagePicturebox.Name = "MusicIns_ImagePicturebox";
            this.MusicIns_ImagePicturebox.Size = new System.Drawing.Size(302, 402);
            this.MusicIns_ImagePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MusicIns_ImagePicturebox.TabIndex = 20;
            this.MusicIns_ImagePicturebox.TabStop = false;
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.Enabled = false;
            this.ReserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ReserveBtn.Location = new System.Drawing.Point(451, 182);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(121, 47);
            this.ReserveBtn.TabIndex = 40;
            this.ReserveBtn.Text = "Reserve";
            this.ReserveBtn.UseVisualStyleBackColor = true;
            this.ReserveBtn.Visible = false;
            this.ReserveBtn.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Enabled = false;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ReturnBtn.Location = new System.Drawing.Point(451, 182);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(121, 47);
            this.ReturnBtn.TabIndex = 41;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Visible = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click_1);
            // 
            // RateBtn
            // 
            this.RateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.RateBtn.Location = new System.Drawing.Point(451, 446);
            this.RateBtn.Name = "RateBtn";
            this.RateBtn.Size = new System.Drawing.Size(121, 47);
            this.RateBtn.TabIndex = 42;
            this.RateBtn.Text = "Rate it!";
            this.RateBtn.UseVisualStyleBackColor = true;
            this.RateBtn.Click += new System.EventHandler(this.RateBtn_Click);
            // 
            // InUse
            // 
            this.InUse.AutoSize = true;
            this.InUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.InUse.Location = new System.Drawing.Point(483, 194);
            this.InUse.Name = "InUse";
            this.InUse.Size = new System.Drawing.Size(59, 23);
            this.InUse.TabIndex = 48;
            this.InUse.Text = "InUse";
            this.InUse.Visible = false;
            // 
            // RateLabel
            // 
            this.RateLabel.Location = new System.Drawing.Point(113, 578);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(105, 29);
            this.RateLabel.TabIndex = 49;
            this.RateLabel.Text = "label1";
            this.RateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VeryPoor
            // 
            this.VeryPoor.AutoSize = true;
            this.VeryPoor.Location = new System.Drawing.Point(451, 262);
            this.VeryPoor.Name = "VeryPoor";
            this.VeryPoor.Size = new System.Drawing.Size(111, 27);
            this.VeryPoor.TabIndex = 43;
            this.VeryPoor.TabStop = true;
            this.VeryPoor.Text = "VeryPoor";
            this.VeryPoor.UseVisualStyleBackColor = true;
            // 
            // Poor
            // 
            this.Poor.AutoSize = true;
            this.Poor.Location = new System.Drawing.Point(451, 295);
            this.Poor.Name = "Poor";
            this.Poor.Size = new System.Drawing.Size(69, 27);
            this.Poor.TabIndex = 44;
            this.Poor.TabStop = true;
            this.Poor.Text = "Poor";
            this.Poor.UseVisualStyleBackColor = true;
            // 
            // Good
            // 
            this.Good.AutoSize = true;
            this.Good.Location = new System.Drawing.Point(451, 328);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(81, 27);
            this.Good.TabIndex = 45;
            this.Good.TabStop = true;
            this.Good.Text = "Good";
            this.Good.UseVisualStyleBackColor = true;
            // 
            // VeryGood
            // 
            this.VeryGood.AutoSize = true;
            this.VeryGood.Location = new System.Drawing.Point(451, 361);
            this.VeryGood.Name = "VeryGood";
            this.VeryGood.Size = new System.Drawing.Size(123, 27);
            this.VeryGood.TabIndex = 46;
            this.VeryGood.TabStop = true;
            this.VeryGood.Text = "VeryGood";
            this.VeryGood.UseVisualStyleBackColor = true;
            // 
            // Excellent
            // 
            this.Excellent.AutoSize = true;
            this.Excellent.Location = new System.Drawing.Point(451, 394);
            this.Excellent.Name = "Excellent";
            this.Excellent.Size = new System.Drawing.Size(112, 27);
            this.Excellent.TabIndex = 47;
            this.Excellent.TabStop = true;
            this.Excellent.Text = "Excellent";
            this.Excellent.UseVisualStyleBackColor = true;
            // 
            // Music_Instrument_Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 639);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.InUse);
            this.Controls.Add(this.Excellent);
            this.Controls.Add(this.VeryGood);
            this.Controls.Add(this.Good);
            this.Controls.Add(this.Poor);
            this.Controls.Add(this.VeryPoor);
            this.Controls.Add(this.RateBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.ReserveBtn);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SectionNameLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Music_Name);
            this.Controls.Add(this.MusicIns_ImagePicturebox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSalmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Music_Instrument_Details_Form";
            this.Text = "Music_Instrument_Details_Form";
            this.Load += new System.EventHandler(this.Music_Instrument_Details_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MusicIns_ImagePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SectionNameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Music_Name;
        private System.Windows.Forms.PictureBox MusicIns_ImagePicturebox;
        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button RateBtn;
        private System.Windows.Forms.Label InUse;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.RadioButton VeryPoor;
        private System.Windows.Forms.RadioButton Poor;
        private System.Windows.Forms.RadioButton Good;
        private System.Windows.Forms.RadioButton VeryGood;
        private System.Windows.Forms.RadioButton Excellent;
    }
}