namespace TarlaOtomasyonProjesi2.Forms
{
    partial class PrintForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPrint = new FontAwesome.Sharp.IconButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnMail = new FontAwesome.Sharp.IconButton();
            this.BtnDbYedekAl = new FontAwesome.Sharp.IconButton();
            this.lblTarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 471);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(462, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 110);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yükleniyor...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.BtnPrint.FlatAppearance.BorderSize = 0;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnPrint.IconColor = System.Drawing.Color.White;
            this.BtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrint.IconSize = 30;
            this.BtnPrint.Location = new System.Drawing.Point(414, 499);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(261, 47);
            this.BtnPrint.TabIndex = 28;
            this.BtnPrint.Text = "Yazdır";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(435, 562);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 19);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "İşçi ve Ekipman Maliyetlerini  Ekle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BtnMail
            // 
            this.BtnMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnMail.FlatAppearance.BorderSize = 0;
            this.BtnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMail.ForeColor = System.Drawing.Color.White;
            this.BtnMail.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.BtnMail.IconColor = System.Drawing.Color.White;
            this.BtnMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMail.IconSize = 30;
            this.BtnMail.Location = new System.Drawing.Point(865, 481);
            this.BtnMail.Name = "BtnMail";
            this.BtnMail.Size = new System.Drawing.Size(189, 47);
            this.BtnMail.TabIndex = 44;
            this.BtnMail.Text = "Pdf Mail Gönder";
            this.BtnMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMail.UseVisualStyleBackColor = false;
            this.BtnMail.Click += new System.EventHandler(this.BtnMail_Click);
            // 
            // BtnDbYedekAl
            // 
            this.BtnDbYedekAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDbYedekAl.FlatAppearance.BorderSize = 0;
            this.BtnDbYedekAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDbYedekAl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDbYedekAl.ForeColor = System.Drawing.Color.White;
            this.BtnDbYedekAl.IconChar = FontAwesome.Sharp.IconChar.CloudArrowUp;
            this.BtnDbYedekAl.IconColor = System.Drawing.Color.White;
            this.BtnDbYedekAl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDbYedekAl.IconSize = 30;
            this.BtnDbYedekAl.Location = new System.Drawing.Point(865, 534);
            this.BtnDbYedekAl.Name = "BtnDbYedekAl";
            this.BtnDbYedekAl.Size = new System.Drawing.Size(189, 47);
            this.BtnDbYedekAl.TabIndex = 45;
            this.BtnDbYedekAl.Text = "Veritabanı Yedekle";
            this.BtnDbYedekAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDbYedekAl.UseVisualStyleBackColor = false;
            this.BtnDbYedekAl.Click += new System.EventHandler(this.BtnDbYedekAl_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarih.Location = new System.Drawing.Point(0, 547);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(160, 49);
            this.lblTarih.TabIndex = 46;
            this.lblTarih.Text = "11/11/2021";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 596);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.BtnDbYedekAl);
            this.Controls.Add(this.BtnMail);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintForm";
            this.Text = "1078, 596";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnPrint;
        private CheckBox checkBox1;
        private FontAwesome.Sharp.IconButton BtnMail;
        private FontAwesome.Sharp.IconButton BtnDbYedekAl;
        private Label lblTarih;
    }
}