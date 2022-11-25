namespace TarlaOtomasyonProjesi2.Forms
{
    partial class MaliyetGoruntuleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDiger = new FontAwesome.Sharp.IconButton();
            this.BtnTohum = new FontAwesome.Sharp.IconButton();
            this.BtnGubre = new FontAwesome.Sharp.IconButton();
            this.BtnMazot = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnİlac = new FontAwesome.Sharp.IconButton();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textMazotGider = new System.Windows.Forms.TextBox();
            this.textGubre = new System.Windows.Forms.TextBox();
            this.textTohum = new System.Windows.Forms.TextBox();
            this.textDiger = new System.Windows.Forms.TextBox();
            this.textİlac = new System.Windows.Forms.TextBox();
            this.BtnToplamMaliyet = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(267, 114);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnDiger
            // 
            this.BtnDiger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnDiger.Enabled = false;
            this.BtnDiger.FlatAppearance.BorderSize = 0;
            this.BtnDiger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiger.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDiger.ForeColor = System.Drawing.Color.White;
            this.BtnDiger.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.BtnDiger.IconColor = System.Drawing.Color.White;
            this.BtnDiger.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDiger.IconSize = 30;
            this.BtnDiger.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnDiger.Location = new System.Drawing.Point(813, 351);
            this.BtnDiger.Name = "BtnDiger";
            this.BtnDiger.Size = new System.Drawing.Size(244, 215);
            this.BtnDiger.TabIndex = 29;
            this.BtnDiger.Text = " ";
            this.BtnDiger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDiger.UseVisualStyleBackColor = false;
            // 
            // BtnTohum
            // 
            this.BtnTohum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.BtnTohum.Enabled = false;
            this.BtnTohum.FlatAppearance.BorderSize = 0;
            this.BtnTohum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTohum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTohum.ForeColor = System.Drawing.Color.White;
            this.BtnTohum.IconChar = FontAwesome.Sharp.IconChar.WheatAlt;
            this.BtnTohum.IconColor = System.Drawing.Color.White;
            this.BtnTohum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTohum.IconSize = 30;
            this.BtnTohum.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnTohum.Location = new System.Drawing.Point(547, 351);
            this.BtnTohum.Name = "BtnTohum";
            this.BtnTohum.Size = new System.Drawing.Size(246, 215);
            this.BtnTohum.TabIndex = 30;
            this.BtnTohum.Text = " ";
            this.BtnTohum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTohum.UseVisualStyleBackColor = false;
            // 
            // BtnGubre
            // 
            this.BtnGubre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGubre.Enabled = false;
            this.BtnGubre.FlatAppearance.BorderSize = 0;
            this.BtnGubre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGubre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGubre.ForeColor = System.Drawing.Color.White;
            this.BtnGubre.IconChar = FontAwesome.Sharp.IconChar.Campground;
            this.BtnGubre.IconColor = System.Drawing.Color.White;
            this.BtnGubre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGubre.IconSize = 30;
            this.BtnGubre.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnGubre.Location = new System.Drawing.Point(286, 351);
            this.BtnGubre.Name = "BtnGubre";
            this.BtnGubre.Size = new System.Drawing.Size(244, 215);
            this.BtnGubre.TabIndex = 31;
            this.BtnGubre.Text = " ";
            this.BtnGubre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGubre.UseVisualStyleBackColor = false;
            // 
            // BtnMazot
            // 
            this.BtnMazot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.BtnMazot.Enabled = false;
            this.BtnMazot.FlatAppearance.BorderSize = 0;
            this.BtnMazot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMazot.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMazot.ForeColor = System.Drawing.Color.White;
            this.BtnMazot.IconChar = FontAwesome.Sharp.IconChar.GasPump;
            this.BtnMazot.IconColor = System.Drawing.Color.White;
            this.BtnMazot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMazot.IconSize = 30;
            this.BtnMazot.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnMazot.Location = new System.Drawing.Point(13, 351);
            this.BtnMazot.Name = "BtnMazot";
            this.BtnMazot.Size = new System.Drawing.Size(257, 215);
            this.BtnMazot.TabIndex = 32;
            this.BtnMazot.Text = " ";
            this.BtnMazot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMazot.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 23);
            this.textBox1.TabIndex = 33;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Parsel Numarasıyla Tarla Arama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btnİlac
            // 
            this.Btnİlac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.Btnİlac.Enabled = false;
            this.Btnİlac.FlatAppearance.BorderSize = 0;
            this.Btnİlac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnİlac.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnİlac.ForeColor = System.Drawing.Color.White;
            this.Btnİlac.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.Btnİlac.IconColor = System.Drawing.Color.White;
            this.Btnİlac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btnİlac.IconSize = 30;
            this.Btnİlac.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btnİlac.Location = new System.Drawing.Point(13, 191);
            this.Btnİlac.Name = "Btnİlac";
            this.Btnİlac.Size = new System.Drawing.Size(517, 151);
            this.Btnİlac.TabIndex = 35;
            this.Btnİlac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnİlac.UseVisualStyleBackColor = false;
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(202)))), ((int)(((byte)(226)))));
            this.pieChart1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pieChart1.Location = new System.Drawing.Point(547, 12);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(0);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(510, 330);
            this.pieChart1.TabIndex = 36;
            this.pieChart1.Text = "pieChart1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "İLAÇ GİDERLERİ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "MAZOT GİDERLERİ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(335, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "GÜBRE GİDERLERİ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(591, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "TOHUM GİDERLERİ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(869, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "DİĞER GİDERLER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(318, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 19);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "İşçi ve Ekipman Maliyet Ekle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textMazotGider
            // 
            this.textMazotGider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.textMazotGider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMazotGider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textMazotGider.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textMazotGider.Location = new System.Drawing.Point(13, 387);
            this.textMazotGider.Multiline = true;
            this.textMazotGider.Name = "textMazotGider";
            this.textMazotGider.ReadOnly = true;
            this.textMazotGider.Size = new System.Drawing.Size(257, 197);
            this.textMazotGider.TabIndex = 50;
            this.textMazotGider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textGubre
            // 
            this.textGubre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textGubre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGubre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textGubre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textGubre.Location = new System.Drawing.Point(286, 387);
            this.textGubre.Multiline = true;
            this.textGubre.Name = "textGubre";
            this.textGubre.ReadOnly = true;
            this.textGubre.Size = new System.Drawing.Size(244, 197);
            this.textGubre.TabIndex = 51;
            this.textGubre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTohum
            // 
            this.textTohum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.textTohum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTohum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textTohum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textTohum.Location = new System.Drawing.Point(547, 387);
            this.textTohum.Multiline = true;
            this.textTohum.Name = "textTohum";
            this.textTohum.ReadOnly = true;
            this.textTohum.Size = new System.Drawing.Size(246, 197);
            this.textTohum.TabIndex = 52;
            this.textTohum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDiger
            // 
            this.textDiger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.textDiger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDiger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textDiger.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textDiger.Location = new System.Drawing.Point(813, 387);
            this.textDiger.Multiline = true;
            this.textDiger.Name = "textDiger";
            this.textDiger.ReadOnly = true;
            this.textDiger.Size = new System.Drawing.Size(244, 197);
            this.textDiger.TabIndex = 53;
            this.textDiger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textİlac
            // 
            this.textİlac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.textİlac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textİlac.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textİlac.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textİlac.Location = new System.Drawing.Point(13, 226);
            this.textİlac.Multiline = true;
            this.textİlac.Name = "textİlac";
            this.textİlac.ReadOnly = true;
            this.textİlac.Size = new System.Drawing.Size(517, 116);
            this.textİlac.TabIndex = 54;
            // 
            // BtnToplamMaliyet
            // 
            this.BtnToplamMaliyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.BtnToplamMaliyet.Enabled = false;
            this.BtnToplamMaliyet.FlatAppearance.BorderSize = 0;
            this.BtnToplamMaliyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToplamMaliyet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnToplamMaliyet.ForeColor = System.Drawing.Color.White;
            this.BtnToplamMaliyet.IconChar = FontAwesome.Sharp.IconChar.TurkishLiraSign;
            this.BtnToplamMaliyet.IconColor = System.Drawing.Color.White;
            this.BtnToplamMaliyet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnToplamMaliyet.IconSize = 30;
            this.BtnToplamMaliyet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnToplamMaliyet.Location = new System.Drawing.Point(336, 71);
            this.BtnToplamMaliyet.Name = "BtnToplamMaliyet";
            this.BtnToplamMaliyet.Size = new System.Drawing.Size(156, 114);
            this.BtnToplamMaliyet.TabIndex = 55;
            this.BtnToplamMaliyet.Text = "    TOPLAM";
            this.BtnToplamMaliyet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnToplamMaliyet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnToplamMaliyet.UseVisualStyleBackColor = false;
            // 
            // MaliyetGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(202)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1078, 596);
            this.Controls.Add(this.BtnToplamMaliyet);
            this.Controls.Add(this.textİlac);
            this.Controls.Add(this.textDiger);
            this.Controls.Add(this.textTohum);
            this.Controls.Add(this.textGubre);
            this.Controls.Add(this.textMazotGider);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.Btnİlac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnMazot);
            this.Controls.Add(this.BtnGubre);
            this.Controls.Add(this.BtnTohum);
            this.Controls.Add(this.BtnDiger);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaliyetGoruntuleme";
            this.Text = "1094, 596";
            this.Load += new System.EventHandler(this.MaliyetGoruntuleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton BtnDiger;
        private FontAwesome.Sharp.IconButton BtnTohum;
        private FontAwesome.Sharp.IconButton BtnGubre;
        private FontAwesome.Sharp.IconButton BtnMazot;
        private TextBox textBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton Btnİlac;
        private LiveCharts.WinForms.PieChart pieChart1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private TextBox textMazotGider;
        private TextBox textGubre;
        private TextBox textTohum;
        private TextBox textDiger;
        private TextBox textİlac;
        private FontAwesome.Sharp.IconButton BtnToplamMaliyet;
    }
}