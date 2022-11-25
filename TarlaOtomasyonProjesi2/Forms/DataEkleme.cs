using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarlaOtomasyonProjesi2.DAL;
using TarlaOtomasyonProjesi2.Entities;
using TarlaOtomasyonProjesi2.Forms;

namespace TarlaOtomasyonProjesi2.Forms
{
    public partial class DataEkleme : Form
    {

        // fields
        private TextBox[] _TextBoxes;
        private int _CurrentTarlaID=0;
      
        public DataEkleme()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _TextBoxes= new TextBox[] {
                textBoxTarlaParselNo,
                textBoxDonum,
                textBoxMazotBirim,
                textBoxMazotToplamLitre,
                textBoxGubreBirim,
                textBoxGubreKg,
                textBoxIlacEkim1,
                textBoxIlacEkim2,
                textBoxTohumBirimFiyati,
                textBoxTohumToplam,
                textBoxBicimMasraf,
                //textBoxEkipmanMaliyet,
                textBoxDigerMasraf,
                textBoxHolder,
                textBoxDigerİlacMasraf

            };
        }


        #region functions
        private bool TextBoxControl()
        {


            TextBox[] textBoxes =
            {
                textBoxDonum,
                textBoxMazotBirim,
                textBoxMazotToplamLitre,
                textBoxGubreBirim,
                textBoxGubreKg,
                textBoxIlacEkim1,
                textBoxIlacEkim2,
                textBoxTohumBirimFiyati,
                textBoxTohumToplam,
                textBoxBicimMasraf,
                //textBoxEkipmanMaliyet,
                textBoxDigerMasraf,
                textBoxHolder,
                textBoxDigerİlacMasraf

            };
           

            foreach (var item in textBoxes)
            {
                if (item.Text.Contains('.'))
                {
                    MessageBox.Show("Küsüratlı Sayıları virgül ile giriniz");
                    return false;

                }
                if (item.Text == String.Empty)
                {
                    MessageBox.Show("Tüm alanları doldurunuz");
                    return false;
                }
            }

            if (textBoxTarlaParselNo.Text == String.Empty)
            {

                MessageBox.Show("Tüm alanları doldurunuz");
                return false;
            }

            return true;
        }

        public double TarlaMaliyetHesapla(Tarla tarla)
        {

            var mazot = tarla.MatozLitre * tarla.MatozLitreBirimFiyat;

            var tohum = tarla.TohumKg * tarla.TohumKgBirimFiyat;

            var gubre = tarla.GubreKg * tarla.GubreKgBirimFiyat;

            var ilac = tarla.IlacEkim1Masraf + tarla.IlacEkim2masraf + tarla.HolderlemeMasraf + tarla.DigerIlacMasraf;

            //var bicim_ekipman_digerMasraf = tarla.DigerNasraflar + tarla.EkipmanMaliyet + tarla.BicimMasrafTotal;

            var bicim_ekipman_digerMasraf = tarla.DigerNasraflar + tarla.BicimMasrafTotal;

            var result = mazot + tohum + gubre + ilac + bicim_ekipman_digerMasraf;

            return (double)result;



        }
        public void AllTextBoxClear()
        {
            _CurrentTarlaID = 0;
            foreach (var item in _TextBoxes)
            {
                item.Clear();
            }
        }
        public async Task DataLoad()
        {
            BtnIscıToplam.Enabled = false;

            var db = new Crud();

            var operation = Task.Run(() => db.GetAllDataAsync());


            dataGridView1.DataSource = await operation;
            BtnIscıToplam.Enabled = true;

        }
        public void LoadingGiFOpen()
        {
            panel1.Visible = true;
            panel1.BringToFront();
        }
        public void LoadingGiFClose()
        {
            panel1.Visible = false;
            panel1.SendToBack();

        }

        #endregion
      
        #region place holder set

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        
        public void PlaceHolderWrite()
        {

            SendMessage(textBoxTarlaParselNo.Handle, EM_SETCUEBANNER, 0, "parsel no");
            SendMessage(textBoxDonum.Handle, EM_SETCUEBANNER, 0, "Dönüm Boyut");
           
            SendMessage(textBoxMazotBirim.Handle, EM_SETCUEBANNER, 0, "Mazotun Litresi TL/lt");
            SendMessage(textBoxMazotToplamLitre.Handle, EM_SETCUEBANNER, 0, "Harcanan Mazot LT");
            
            SendMessage(textBoxTohumBirimFiyati.Handle, EM_SETCUEBANNER, 0, "Tohumun Fiyatı TL/kg");
            SendMessage(textBoxTohumToplam.Handle, EM_SETCUEBANNER, 0, "Harcanan Tohum KG");

            SendMessage(textBoxGubreBirim.Handle, EM_SETCUEBANNER, 0, "Gübre Fiyatı TL/kg");
            SendMessage(textBoxGubreKg.Handle, EM_SETCUEBANNER, 0, "Harcanan Gübre KG");



            SendMessage(textBoxIlacEkim1.Handle, EM_SETCUEBANNER, 0, "... TL");
            SendMessage(textBoxIlacEkim2.Handle, EM_SETCUEBANNER, 0, "... TL");
            SendMessage(textBoxHolder.Handle, EM_SETCUEBANNER, 0, "... TL");
            SendMessage(textBoxDigerİlacMasraf.Handle, EM_SETCUEBANNER, 0, "... TL");


            SendMessage(textBoxBicimMasraf.Handle, EM_SETCUEBANNER, 0, "Biçim Masrafları TL");
           // SendMessage(textBoxEkipmanMaliyet.Handle, EM_SETCUEBANNER, 0, "Ekipman Masrafları TL");
            SendMessage(textBoxDigerMasraf.Handle, EM_SETCUEBANNER, 0, "Diğer Masraflar TL");


        }



        #endregion

        private async  void DataEkleme_Load(object sender, EventArgs e)
        {

            BtnIscıToplam.Enabled = false;
            Globals.GlobalData.Status = false;

            PlaceHolderWrite();
            var db = new Crud();

            var operation = Task.Run(() => db.GetAllDataAsync());
            

            dataGridView1.DataSource = await operation;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Parsel No";
            dataGridView1.Columns[2].HeaderText = "Dönüm Boyut";
            dataGridView1.Columns[3].HeaderText = "Maliyet";
            dataGridView1.Columns[4].HeaderText = "Ekipman Maliyet";
            dataGridView1.Columns[5].HeaderText = "Toplam Tohum KG";
            dataGridView1.Columns[6].HeaderText = "Toplam Gübre KG";
            dataGridView1.Columns[7].HeaderText = "Toplam Mazot Lt";
            dataGridView1.Columns[8].HeaderText = "Tohum Birim Fiyat";
            dataGridView1.Columns[9].HeaderText = "Gübre Birim Fiyat";
            dataGridView1.Columns[10].HeaderText = "Mazot Birim Fiyat";
            dataGridView1.Columns[11].HeaderText = "Biçim Masraf";
            dataGridView1.Columns[12].HeaderText = "Diğer Masraf";
            dataGridView1.Columns[13].HeaderText = "İlaç Masraf 1";
            dataGridView1.Columns[14].HeaderText = "İlaç Masraf 2";
            dataGridView1.Columns[15].HeaderText = "Holder Masraf ";
            dataGridView1.Columns[16].HeaderText = "Diğer İlaç Masraf";


            //MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());
            LoadingGiFClose();
            Globals.GlobalData.Status = true;
            BtnIscıToplam.Enabled = true;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {

           
            AllTextBoxClear();
        }

        private async void BtnEkle_Click(object sender, EventArgs e)
        {
            Globals.GlobalData.Status = false;

            LoadingGiFOpen();
            Tarla tarla = new Tarla();
            if (!TextBoxControl()){ LoadingGiFClose(); Globals.GlobalData.Status = true; return; }
            
            try
            {
                tarla.TarlaParselNo = textBoxTarlaParselNo.Text.TrimEnd();
                tarla.Donum = double.Parse(textBoxDonum.Text.TrimEnd());
                
                tarla.MatozLitreBirimFiyat = double.Parse(textBoxMazotBirim.Text.TrimEnd());
                tarla.MatozLitre = double.Parse(textBoxMazotToplamLitre.Text.Trim());
                
                tarla.GubreKgBirimFiyat = double.Parse(textBoxGubreBirim.Text.TrimEnd());
                tarla.GubreKg = double.Parse(textBoxGubreKg.Text.TrimEnd());
                
                tarla.TohumKgBirimFiyat = double.Parse(textBoxTohumBirimFiyati.Text.TrimEnd());
                tarla.TohumKg = double.Parse(textBoxTohumToplam.Text.TrimEnd());
                
                tarla.IlacEkim1Masraf = double.Parse(textBoxIlacEkim1.Text.TrimEnd());
                tarla.IlacEkim2masraf = double.Parse(textBoxIlacEkim2.Text.TrimEnd());
                tarla.HolderlemeMasraf = double.Parse(textBoxHolder.Text.TrimEnd());
                tarla.DigerIlacMasraf = double.Parse(textBoxDigerİlacMasraf.Text.TrimEnd());
                
                tarla.BicimMasrafTotal = double.Parse(textBoxBicimMasraf.Text.TrimEnd());
                tarla.EkipmanMaliyet = 0;
               
                tarla.DigerNasraflar=double.Parse(textBoxDigerMasraf.Text.TrimEnd());
                
                tarla.Maliyet = TarlaMaliyetHesapla(tarla);




                Crud crud = new Crud();

                await crud.AddAsync(tarla);

                AllTextBoxClear();

                DataLoad();
              

            }
            catch (Exception)
            {

                MessageBox.Show("lütfen verileri formatına uygun yazınız");
                Globals.GlobalData.Status = true;
            }
            finally
            {
                LoadingGiFClose();
                Globals.GlobalData.Status = true;
            }


        }

        private async void BtnSil_Click(object sender, EventArgs e)
        {

            


          
            Globals.GlobalData.Status = false;

            DialogResult dialogResult = MessageBox.Show("Onaylıyor musunuz", "Kayıt Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (_CurrentTarlaID==0)
                    {
                        MessageBox.Show("Silmek İstediğiniz Tarlaya Tıklayınız");
                        return;
                    }
                    Crud crud = new Crud();
                    crud.Delete(_CurrentTarlaID);
                    _CurrentTarlaID = 0;
                }
                catch (Exception)
                {

                    MessageBox.Show("Silmek İstediğiniz Tarlaya Tıklayınız");
                    Globals.GlobalData.Status = true;
                }
                finally
                {
                    AllTextBoxClear();
                    await DataLoad();
                    Globals.GlobalData.Status = true;
                }
            }
         

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentTarlaID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            textBoxTarlaParselNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            textBoxDonum.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            textBoxMazotBirim.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();

            textBoxMazotToplamLitre.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

            textBoxGubreBirim.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

            textBoxGubreKg.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            textBoxTohumBirimFiyati.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

            textBoxTohumToplam.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            textBoxIlacEkim1.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

            textBoxIlacEkim2.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();

            textBoxHolder.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();

            textBoxDigerİlacMasraf.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();

            textBoxBicimMasraf.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

            var result31 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            textBoxDigerMasraf.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();




        }
        
        private async void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Globals.GlobalData.Status = false;
            DialogResult dialogResult = MessageBox.Show("Onaylıyor musunuz", "Kayıt Güncelleme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (_CurrentTarlaID == 0)
                    {
                        MessageBox.Show("Güncellemek İstediğiniz Tarlaya Tıklayınız");
                        return;
                    }

                    Crud crud = new Crud();

                    Tarla tarla = new Tarla();

                    tarla.TarlaParselNo = textBoxTarlaParselNo.Text.TrimEnd();
                    tarla.Donum = double.Parse(textBoxDonum.Text.TrimEnd());

                    tarla.MatozLitreBirimFiyat = double.Parse(textBoxMazotBirim.Text.TrimEnd());
                    tarla.MatozLitre = double.Parse(textBoxMazotToplamLitre.Text.Trim());

                    tarla.GubreKgBirimFiyat = double.Parse(textBoxGubreBirim.Text.TrimEnd());
                    tarla.GubreKg = double.Parse(textBoxGubreKg.Text.TrimEnd());

                    tarla.TohumKgBirimFiyat = double.Parse(textBoxTohumBirimFiyati.Text.TrimEnd());
                    tarla.TohumKg = double.Parse(textBoxTohumToplam.Text.TrimEnd());

                    tarla.IlacEkim1Masraf = double.Parse(textBoxIlacEkim1.Text.TrimEnd());
                    tarla.IlacEkim2masraf = double.Parse(textBoxIlacEkim2.Text.TrimEnd());
                    tarla.HolderlemeMasraf = double.Parse(textBoxHolder.Text.TrimEnd());
                    tarla.DigerIlacMasraf = double.Parse(textBoxDigerİlacMasraf.Text.TrimEnd());

                    tarla.BicimMasrafTotal = double.Parse(textBoxBicimMasraf.Text.TrimEnd());
                   // tarla.EkipmanMaliyet = double.Parse(textBoxEkipmanMaliyet.Text.TrimEnd());
                    tarla.DigerNasraflar = double.Parse(textBoxDigerMasraf.Text.TrimEnd());

                    tarla.Maliyet = TarlaMaliyetHesapla(tarla);


                     
                    await crud.UpdateTarlaAsync(_CurrentTarlaID, tarla);

                    _CurrentTarlaID = 0;

                }
                catch (Exception)
                {

                    MessageBox.Show("Güncellemek İstediğiniz Tarlaya Tıklayınız ve Verileri Uygun Formatta Giriniz");
                    Globals.GlobalData.Status = true;
                }
                finally
                {
                    AllTextBoxClear();
                    await DataLoad();
                    Globals.GlobalData.Status = true;
                }
            }
        }

        private void BtnIscıToplam_Click(object sender, EventArgs e)
        {

            if (!Globals.GlobalData.İsci_Ekran_Acik_Mi)
            {
                
                this.Enabled = false;
                Form frm = new IscıMaasEkranı(this);
                frm.Show();
                Globals.GlobalData.İsci_Ekran_Acik_Mi = true;
            }


        }
    }
}
