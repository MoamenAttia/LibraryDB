namespace Egypt_National_Library
{
    partial class Book_Details_Form
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
            this.Book_ImagePicturebox = new System.Windows.Forms.PictureBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.SectionNameLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AuthorLNameLabel = new System.Windows.Forms.Label();
            this.AuthorMNameLabel = new System.Windows.Forms.Label();
            this.AuthorFNameLabel = new System.Windows.Forms.Label();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Return = new System.Windows.Forms.Button();
            this.RateBtn = new System.Windows.Forms.Button();
            this.VeryPoor = new System.Windows.Forms.RadioButton();
            this.Poor = new System.Windows.Forms.RadioButton();
            this.Good = new System.Windows.Forms.RadioButton();
            this.VeryGood = new System.Windows.Forms.RadioButton();
            this.Excellent = new System.Windows.Forms.RadioButton();
            this.InUse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Book_ImagePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_ImagePicturebox
            // 
            this.Book_ImagePicturebox.Location = new System.Drawing.Point(45, 12);
            this.Book_ImagePicturebox.Name = "Book_ImagePicturebox";
            this.Book_ImagePicturebox.Size = new System.Drawing.Size(287, 402);
            this.Book_ImagePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Book_ImagePicturebox.TabIndex = 0;
            this.Book_ImagePicturebox.TabStop = false;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.BookNameLabel.Location = new System.Drawing.Point(45, 449);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(287, 98);
            this.BookNameLabel.TabIndex = 1;
            this.BookNameLabel.Text = "Book Name";
            this.BookNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(367, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author FName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(367, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author MName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(367, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author LName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(367, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(367, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(367, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Section Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(367, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Release Date";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(562, 343);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(206, 35);
            this.ReleaseDateLabel.TabIndex = 15;
            this.ReleaseDateLabel.Text = "Release Date";
            this.ReleaseDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SectionNameLabel
            // 
            this.SectionNameLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.SectionNameLabel.Location = new System.Drawing.Point(562, 291);
            this.SectionNameLabel.Name = "SectionNameLabel";
            this.SectionNameLabel.Size = new System.Drawing.Size(206, 35);
            this.SectionNameLabel.TabIndex = 14;
            this.SectionNameLabel.Text = "Section Name";
            this.SectionNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.PublisherLabel.Location = new System.Drawing.Point(562, 238);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(206, 35);
            this.PublisherLabel.TabIndex = 13;
            this.PublisherLabel.Text = "Publisher";
            this.PublisherLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.PriceLabel.Location = new System.Drawing.Point(562, 184);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(206, 35);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthorLNameLabel
            // 
            this.AuthorLNameLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.AuthorLNameLabel.Location = new System.Drawing.Point(562, 131);
            this.AuthorLNameLabel.Name = "AuthorLNameLabel";
            this.AuthorLNameLabel.Size = new System.Drawing.Size(206, 35);
            this.AuthorLNameLabel.TabIndex = 11;
            this.AuthorLNameLabel.Text = "Author LName";
            this.AuthorLNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthorMNameLabel
            // 
            this.AuthorMNameLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.AuthorMNameLabel.Location = new System.Drawing.Point(562, 82);
            this.AuthorMNameLabel.Name = "AuthorMNameLabel";
            this.AuthorMNameLabel.Size = new System.Drawing.Size(206, 35);
            this.AuthorMNameLabel.TabIndex = 10;
            this.AuthorMNameLabel.Text = "Author MName";
            this.AuthorMNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthorFNameLabel
            // 
            this.AuthorFNameLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.AuthorFNameLabel.Location = new System.Drawing.Point(562, 35);
            this.AuthorFNameLabel.Name = "AuthorFNameLabel";
            this.AuthorFNameLabel.Size = new System.Drawing.Size(206, 35);
            this.AuthorFNameLabel.TabIndex = 9;
            this.AuthorFNameLabel.Text = "Author FName";
            this.AuthorFNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.Enabled = false;
            this.BorrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowBtn.ForeColor = System.Drawing.Color.DarkSalmon;
            this.BorrowBtn.Location = new System.Drawing.Point(384, 397);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(142, 36);
            this.BorrowBtn.TabIndex = 16;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = true;
            this.BorrowBtn.Visible = false;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Enabled = false;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBtn.ForeColor = System.Drawing.Color.DarkSalmon;
            this.ReturnBtn.Location = new System.Drawing.Point(566, 397);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(142, 36);
            this.ReturnBtn.TabIndex = 17;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Visible = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 656);
            this.panel1.TabIndex = 18;
            // 
            // Return
            // 
            this.Return.FlatAppearance.BorderSize = 2;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Return.Location = new System.Drawing.Point(738, 608);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(80, 36);
            this.Return.TabIndex = 19;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // RateBtn
            // 
            this.RateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateBtn.ForeColor = System.Drawing.Color.DarkSalmon;
            this.RateBtn.Location = new System.Drawing.Point(566, 511);
            this.RateBtn.Name = "RateBtn";
            this.RateBtn.Size = new System.Drawing.Size(142, 36);
            this.RateBtn.TabIndex = 20;
            this.RateBtn.Text = "Rate it!";
            this.RateBtn.UseVisualStyleBackColor = true;
            this.RateBtn.Click += new System.EventHandler(this.RateBtn_Click);
            // 
            // VeryPoor
            // 
            this.VeryPoor.AutoSize = true;
            this.VeryPoor.ForeColor = System.Drawing.Color.DarkSalmon;
            this.VeryPoor.Location = new System.Drawing.Point(371, 467);
            this.VeryPoor.Name = "VeryPoor";
            this.VeryPoor.Size = new System.Drawing.Size(138, 32);
            this.VeryPoor.TabIndex = 21;
            this.VeryPoor.TabStop = true;
            this.VeryPoor.Text = "VeryPoor";
            this.VeryPoor.UseVisualStyleBackColor = true;
            // 
            // Poor
            // 
            this.Poor.AutoSize = true;
            this.Poor.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Poor.Location = new System.Drawing.Point(371, 500);
            this.Poor.Name = "Poor";
            this.Poor.Size = new System.Drawing.Size(84, 32);
            this.Poor.TabIndex = 22;
            this.Poor.TabStop = true;
            this.Poor.Text = "Poor";
            this.Poor.UseVisualStyleBackColor = true;
            // 
            // Good
            // 
            this.Good.AutoSize = true;
            this.Good.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Good.Location = new System.Drawing.Point(371, 533);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(99, 32);
            this.Good.TabIndex = 23;
            this.Good.TabStop = true;
            this.Good.Text = "Good";
            this.Good.UseVisualStyleBackColor = true;
            // 
            // VeryGood
            // 
            this.VeryGood.AutoSize = true;
            this.VeryGood.ForeColor = System.Drawing.Color.DarkSalmon;
            this.VeryGood.Location = new System.Drawing.Point(371, 566);
            this.VeryGood.Name = "VeryGood";
            this.VeryGood.Size = new System.Drawing.Size(153, 32);
            this.VeryGood.TabIndex = 24;
            this.VeryGood.TabStop = true;
            this.VeryGood.Text = "VeryGood";
            this.VeryGood.UseVisualStyleBackColor = true;
            // 
            // Excellent
            // 
            this.Excellent.AutoSize = true;
            this.Excellent.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Excellent.Location = new System.Drawing.Point(371, 599);
            this.Excellent.Name = "Excellent";
            this.Excellent.Size = new System.Drawing.Size(136, 32);
            this.Excellent.TabIndex = 25;
            this.Excellent.TabStop = true;
            this.Excellent.Text = "Excellent";
            this.Excellent.UseVisualStyleBackColor = true;
            // 
            // InUse
            // 
            this.InUse.AutoSize = true;
            this.InUse.ForeColor = System.Drawing.Color.DarkSalmon;
            this.InUse.Location = new System.Drawing.Point(517, 436);
            this.InUse.Name = "InUse";
            this.InUse.Size = new System.Drawing.Size(74, 28);
            this.InUse.TabIndex = 27;
            this.InUse.Text = "InUse";
            this.InUse.Visible = false;
            // 
            // Book_Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 656);
            this.Controls.Add(this.InUse);
            this.Controls.Add(this.Excellent);
            this.Controls.Add(this.VeryGood);
            this.Controls.Add(this.Good);
            this.Controls.Add(this.Poor);
            this.Controls.Add(this.VeryPoor);
            this.Controls.Add(this.RateBtn);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.BorrowBtn);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.SectionNameLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AuthorLNameLabel);
            this.Controls.Add(this.AuthorMNameLabel);
            this.Controls.Add(this.AuthorFNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.Book_ImagePicturebox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Book_Details_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Details_Form";
            this.Load += new System.EventHandler(this.Book_Details_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Book_ImagePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Book_ImagePicturebox;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label SectionNameLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label AuthorLNameLabel;
        private System.Windows.Forms.Label AuthorMNameLabel;
        private System.Windows.Forms.Label AuthorFNameLabel;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button RateBtn;
        private System.Windows.Forms.RadioButton VeryPoor;
        private System.Windows.Forms.RadioButton Poor;
        private System.Windows.Forms.RadioButton Good;
        private System.Windows.Forms.RadioButton VeryGood;
        private System.Windows.Forms.RadioButton Excellent;
        private System.Windows.Forms.Label InUse;
    }
}