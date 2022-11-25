namespace TarlaOtomasyonProjesi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.QuitBtn = new FontAwesome.Sharp.IconButton();
            this.MaliyetYazdirBtn = new FontAwesome.Sharp.IconButton();
            this.MaliyetGosterBtn = new FontAwesome.Sharp.IconButton();
            this.TarlaEkleBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.BtnQuit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.MenuPanel.Controls.Add(this.QuitBtn);
            this.MenuPanel.Controls.Add(this.MaliyetYazdirBtn);
            this.MenuPanel.Controls.Add(this.MaliyetGosterBtn);
            this.MenuPanel.Controls.Add(this.TarlaEkleBtn);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(151, 674);
            this.MenuPanel.TabIndex = 0;
            // 
            // QuitBtn
            // 
            this.QuitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuitBtn.FlatAppearance.BorderSize = 0;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.QuitBtn.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.QuitBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.QuitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.QuitBtn.Location = new System.Drawing.Point(0, 601);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.QuitBtn.Size = new System.Drawing.Size(151, 73);
            this.QuitBtn.TabIndex = 4;
            this.QuitBtn.Text = "Çıkış";
            this.QuitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // MaliyetYazdirBtn
            // 
            this.MaliyetYazdirBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaliyetYazdirBtn.FlatAppearance.BorderSize = 0;
            this.MaliyetYazdirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaliyetYazdirBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaliyetYazdirBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.MaliyetYazdirBtn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.MaliyetYazdirBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.MaliyetYazdirBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaliyetYazdirBtn.Location = new System.Drawing.Point(0, 278);
            this.MaliyetYazdirBtn.Name = "MaliyetYazdirBtn";
            this.MaliyetYazdirBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MaliyetYazdirBtn.Size = new System.Drawing.Size(151, 100);
            this.MaliyetYazdirBtn.TabIndex = 3;
            this.MaliyetYazdirBtn.Text = "Yazdır";
            this.MaliyetYazdirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MaliyetYazdirBtn.UseVisualStyleBackColor = true;
            this.MaliyetYazdirBtn.Click += new System.EventHandler(this.MaliyetYazdirBtn_Click);
            // 
            // MaliyetGosterBtn
            // 
            this.MaliyetGosterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaliyetGosterBtn.FlatAppearance.BorderSize = 0;
            this.MaliyetGosterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaliyetGosterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaliyetGosterBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.MaliyetGosterBtn.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.MaliyetGosterBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.MaliyetGosterBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaliyetGosterBtn.Location = new System.Drawing.Point(0, 178);
            this.MaliyetGosterBtn.Name = "MaliyetGosterBtn";
            this.MaliyetGosterBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MaliyetGosterBtn.Size = new System.Drawing.Size(151, 100);
            this.MaliyetGosterBtn.TabIndex = 2;
            this.MaliyetGosterBtn.Text = "Maliyet Detay";
            this.MaliyetGosterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MaliyetGosterBtn.UseVisualStyleBackColor = true;
            this.MaliyetGosterBtn.Click += new System.EventHandler(this.MaliyetGosterBtn_Click);
            // 
            // TarlaEkleBtn
            // 
            this.TarlaEkleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TarlaEkleBtn.FlatAppearance.BorderSize = 0;
            this.TarlaEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TarlaEkleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TarlaEkleBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.TarlaEkleBtn.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.TarlaEkleBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.TarlaEkleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TarlaEkleBtn.Location = new System.Drawing.Point(0, 78);
            this.TarlaEkleBtn.Name = "TarlaEkleBtn";
            this.TarlaEkleBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.TarlaEkleBtn.Size = new System.Drawing.Size(151, 100);
            this.TarlaEkleBtn.TabIndex = 1;
            this.TarlaEkleBtn.Text = "Tarla Ekle";
            this.TarlaEkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TarlaEkleBtn.UseVisualStyleBackColor = true;
            this.TarlaEkleBtn.Click += new System.EventHandler(this.TarlaEkleBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 78);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnMin);
            this.panel2.Controls.Add(this.BtnQuit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(151, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 78);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // BtnMin
            // 
            this.BtnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMin.IconColor = System.Drawing.Color.White;
            this.BtnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMin.Location = new System.Drawing.Point(992, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(39, 76);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnQuit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.BtnQuit.IconColor = System.Drawing.Color.White;
            this.BtnQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnQuit.Location = new System.Drawing.Point(1031, 0);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(61, 76);
            this.BtnQuit.TabIndex = 1;
            this.BtnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(108, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarla Gider Hesaplama Otomasyonu v1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.Color.White;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDate.Location = new System.Drawing.Point(881, 520);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(73, 30);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "asdasd";
            // 
            // PanelContainer
            // 
            this.PanelContainer.Controls.Add(this.LblDate);
            this.PanelContainer.Controls.Add(this.pictureBox2);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(151, 78);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1094, 596);
            this.PanelContainer.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1094, 596);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 674);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel PanelContainer;
        private PictureBox pictureBox2;
        private Label LblDate;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private FontAwesome.Sharp.IconButton QuitBtn;
        private FontAwesome.Sharp.IconButton MaliyetYazdirBtn;
        private FontAwesome.Sharp.IconButton MaliyetGosterBtn;
        private FontAwesome.Sharp.IconButton TarlaEkleBtn;
        private FontAwesome.Sharp.IconButton BtnQuit;
        private FontAwesome.Sharp.IconButton BtnMin;
    }
}