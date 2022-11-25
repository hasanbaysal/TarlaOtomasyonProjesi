using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using TarlaOtomasyonProjesi2.Forms;
namespace TarlaOtomasyonProjesi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.GlobalData.Status = true;
            timer1.Start();
          //  LblDate.Text= DateTime.Now.ToShortDateString();
            //31, 30, 68
            leftBorderBtn=new Panel();
            leftBorderBtn.Size = new Size(7, 100);
            MenuPanel.Controls.Add(leftBorderBtn);  
        }
        #region form_UI


        #region drag borderless form

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm!=null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(childForm);
            PanelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        private void ActiveteButton(object senderBtn,Color color)
        {
            if (senderBtn!=null)
            {

                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(27, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
        private void DisableButton()
        {
            if (currentButton!=null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private struct RGBColors
        {
            public static Color color0 = Color.FromArgb(95, 77, 221);


            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);

        }
        #endregion

        private void TarlaEkleBtn_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            if (!Globals.GlobalData.Status)
            {
                return;
            }
            ActiveteButton(sender, RGBColors.color1);
            OpenChildForm( new DataEkleme());

        }

        private void MaliyetGosterBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (!Globals.GlobalData.Status)
            {
                return;
            }
            ActiveteButton(sender, RGBColors.color2);
            OpenChildForm(new MaliyetGoruntuleme());

        }

        private void MaliyetYazdirBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (!Globals.GlobalData.Status)
            {
                return;
            }
            ActiveteButton(sender, RGBColors.color3);
            OpenChildForm(new PrintForm());

        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            if (Globals.GlobalData.Ýsci_Ekran_Acik_Mi)
            {
                MessageBox.Show("açýk pencereyi kapatýn");
                return;
            }
            if (!Globals.GlobalData.Status)
            {
                MessageBox.Show("arka planda veri aktarýmý devam ediyor... 5 saniye sonra kapatabilirsiniz");
                return;
            }

            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblDate.Text = DateTime.Now.ToString();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}