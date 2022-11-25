using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarlaOtomasyonProjesi2.DAL;
using TarlaOtomasyonProjesi2.Entities;

namespace TarlaOtomasyonProjesi2.Forms
{
    public partial class IscıMaasEkranı : Form
    {
        private Form _rootForm;
        public IscıMaasEkranı()
        {
            InitializeComponent();
        }
        public IscıMaasEkranı(Form rootForm)
        {

            _rootForm = rootForm;
            this.BringToFront();
            InitializeComponent();
        }
        private void IscıMaasEkranı_Load(object sender, EventArgs e)
        {
            Crud crud = new Crud();
            Globals.GlobalData.Status = false;
            label3.Text= "mevcut toplam maaş : " +crud.GetIsci().IsciToplamUcret.ToString()+" TL";
            label4.Text = "mevcut toplam ekipman maliyet : " + crud.GetIsci().EkipmanMasrafYeniOzellik.ToString() + " TL";

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Globals.GlobalData.İsci_Ekran_Acik_Mi = false;
            Globals.GlobalData.Status= true;

            _rootForm.Enabled = true;
            this.Close();
            
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text==String.Empty || textBox2.Text == String.Empty)
                {
                    MessageBox.Show("Her İki Alanı Doldurunuz");
                    return;
                }


                var maas=int.Parse(textBox1.Text);
                var ekipman  = double.Parse(textBox2.Text);

                

                Crud crud = new Crud();
                crud.IsciUpdate(maas,ekipman);



                Globals.GlobalData.İsci_Ekran_Acik_Mi = false;
                _rootForm.Enabled = true;
                Globals.GlobalData.Status = true;
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("beklenmeye bir hata oluştu ! girdiniz sayıyı kontrol edin maaş alanına tam sayı girin");
                
            }
        }
    }
}
