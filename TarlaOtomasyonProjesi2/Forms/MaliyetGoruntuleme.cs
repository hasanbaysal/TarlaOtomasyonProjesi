using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarlaOtomasyonProjesi2.DAL;
using TarlaOtomasyonProjesi2.Entities;
namespace TarlaOtomasyonProjesi2.Forms
{
    public partial class MaliyetGoruntuleme : Form
    {
        private List<Tarla> _Tarlalar;
        private Tarla _tempTarla;
        private int _Id;
        private double _DonumBasinaIsciMaliyet;
        private double _DonumBasinaEkipmanMaliyet;





        public MaliyetGoruntuleme()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _Tarlalar = new List<Tarla>();
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private async void MaliyetGoruntuleme_Load(object sender, EventArgs e)
        {
            Globals.GlobalData.Status = false;

            var db = new Crud();

            var operation = Task.Run(() => db.GetAllDataAsync());


            var data = await operation;

            _Tarlalar = data;

            dataGridView1.DataSource = data.Select(a => new
            {
                ID = a.Id,
                Parsel_NO = a.TarlaParselNo
            }).ToList();
            double _toplamDonum = 0;

            _Tarlalar.ForEach(x => _toplamDonum += x.Donum);

            var _isciToplamMaas= db.GetIsci().IsciToplamUcret;
            var _ekipmanToplamMaliyet= db.GetIsci().EkipmanMasrafYeniOzellik;


            _DonumBasinaIsciMaliyet = _isciToplamMaas / _toplamDonum;
            _DonumBasinaEkipmanMaliyet = _ekipmanToplamMaliyet / _toplamDonum;


            Globals.GlobalData.Status = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var query = from c in _Tarlalar
                            where c.TarlaParselNo.StartsWith(textBox1.Text)
                            select c;

                var SearchResult = query.Select(a => new
                {
                    ID = a.Id,
                    Parsel_NO = a.TarlaParselNo

                }).ToList();

                dataGridView1.DataSource = SearchResult.ToList();
            }
            catch (Exception)
            {

                return;
            }
        }
        bool datagridviewclik = false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridviewclik = true;

            try
            {
                Globals.GlobalData.Status = false;


                 _Id = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());


                Crud crud = new Crud();
                _tempTarla = crud.GetDataById(_Id);
                if (_tempTarla == null)
                {
                    MessageBox.Show("Detayları görüntülemek için tarlaya tıklayınız.");
                    return;
                }


                DetailsShow(_tempTarla);
            }
            catch (Exception)
            {

                return;
            }
            finally
            {

                _Id = 0;

                Globals.GlobalData.Status = true;

            }





        }
        

        public void DetailsShow(Tarla tarla)
        {

            Func<LiveCharts.ChartPoint, string> fu = x => string.Format("{0}{1}", x.Y, x.Participation);
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();


        

            #region ilaç giderleri

            var text_ilaç =
                     "İlaç Ekim 1 Masrafı :. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . " + tarla.IlacEkim1Masraf+" TL" + Environment.NewLine+
                   "İlaç EKim 2 Masrafı :. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . " + tarla.IlacEkim2masraf + " TL" + Environment.NewLine+
                    "Holderleme  Masrafı :. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . " + tarla.HolderlemeMasraf + " TL" + Environment.NewLine+
                     "Diğer İlaç gideri Masrafı :. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . " + tarla.DigerIlacMasraf + " TL" + Environment.NewLine;

                var ilaç_toplam = tarla.IlacEkim1Masraf + tarla.IlacEkim2masraf + tarla.HolderlemeMasraf + tarla.DigerIlacMasraf;
                var donumBasinaİlac = Math.Round((ilaç_toplam / tarla.Donum),2);
                


                text_ilaç += "Toplam ilaçalama Tutar :. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . " + ilaç_toplam + " TL"+
                Environment.NewLine + "Dönüm Başına İlaç Masrafı :. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . " + donumBasinaİlac + "  TL";



                var ilac_data = new { Name = "ilaç", Maliyet = ilaç_toplam };

               textİlac.Text = text_ilaç;


                #endregion

                #region mazot giderleri


                var donumBasinaMazot = Math.Round(((tarla.MatozLitreBirimFiyat * tarla.MatozLitre) / (tarla.Donum)), 2);

                var mazot_gider =
                    "Toplam Kullanılan Mazot"+Environment.NewLine +tarla.MatozLitre +" LT" + Environment.NewLine + Environment.NewLine
                    + "Mazotun Birim Ücreti (TL/lt)"+Environment.NewLine + tarla.MatozLitreBirimFiyat + " TL" + Environment.NewLine + Environment.NewLine
                    + "Toplam Mazot Masrafı" + Environment.NewLine + Math.Round((tarla.MatozLitreBirimFiyat * tarla.MatozLitre),2) + " TL"+Environment.NewLine + Environment.NewLine
                    + "Dönüme Mazot Masrafı" + Environment.NewLine + donumBasinaMazot + " TL";
                    
                textMazotGider.Text = mazot_gider;

             var mazot_data = new { Name = "Mazot", Maliyet= (tarla.MatozLitreBirimFiyat * tarla.MatozLitre) };
                #endregion

                #region gübre giderleri



                var donumBasinaGubre = Math.Round(((tarla.GubreKgBirimFiyat * tarla.GubreKg) / (tarla.Donum)), 2);

                var gubre_gider =
                    "Toplam Kullanılan Gubre" + Environment.NewLine + tarla.GubreKg + " KG" + Environment.NewLine + Environment.NewLine
                    + "Gübrenin Birim Ücreti (TL/Kg)" + Environment.NewLine + tarla.GubreKgBirimFiyat + " TL" + Environment.NewLine + Environment.NewLine
                    + "Toplam Gübre Masrafı" + Environment.NewLine + Math.Round((tarla.GubreKgBirimFiyat * tarla.GubreKg),3) + " TL" + Environment.NewLine + Environment.NewLine
                    + "Dönüme Gübre Masrafı" + Environment.NewLine + donumBasinaGubre + " TL";

                textGubre.Text = gubre_gider;


            var gubre_data = new { Name = "Gübre", Maliyet = (tarla.GubreKgBirimFiyat * tarla.GubreKg) };

                #endregion

                #region tohum giderleri



                var donumBasinaTohum= Math.Round(((tarla.TohumKgBirimFiyat * tarla.TohumKg) / (tarla.Donum)), 2);

                var tohum_gider =
                    "Toplam Kullanılan Tohum" + Environment.NewLine + tarla.TohumKg + " Kg" + Environment.NewLine + Environment.NewLine
                    + "Tohumun Birim Ücreti (TL/Kg)" + Environment.NewLine + tarla.TohumKgBirimFiyat + " TL" + Environment.NewLine + Environment.NewLine
                    + "Toplam Tohum Masrafı" + Environment.NewLine + (tarla.TohumKgBirimFiyat * tarla.TohumKg) + " TL" + Environment.NewLine + Environment.NewLine
                    + "Dönüme Tohum Masrafı" + Environment.NewLine + donumBasinaTohum + " TL";

                textTohum.Text = tohum_gider;


            var tohum_data = new { Name = "Tohum", Maliyet = (tarla.TohumKgBirimFiyat * tarla.TohumKg) };

                #endregion

                #region diger giderler



                var diger_gider =
                    "Biçim Masrafları " + Environment.NewLine + tarla.BicimMasrafTotal + " TL" + Environment.NewLine + Environment.NewLine
                  
                    + "Diğer Masraflar" + Environment.NewLine + tarla.DigerNasraflar + " TL" + Environment.NewLine + Environment.NewLine;
                
                textDiger.Text = diger_gider;

            var diger_data = new { Name = "Diğer", Maliyet=tarla.BicimMasrafTotal+tarla.EkipmanMaliyet+tarla.DigerNasraflar};

                #endregion

                #region Toplam Maliyet

                BtnToplamMaliyet.Text = "    TOPLAM" +
                Environment.NewLine + Environment.NewLine + Math.Round(tarla.Maliyet,3) + Environment.NewLine
                + Environment.NewLine + "TL";

            #endregion




          

            #region anony array 

            var list = new[] { ilac_data, mazot_data, gubre_data, tohum_data, diger_data }.ToList();


            #endregion
            if (checkBox1.Checked)// işçi detayları göster
            {
                //bir dönüm olan işçi maliyeti 


                var isci_masraf = tarla.Donum * _DonumBasinaIsciMaliyet;
                var ekipman_masraf = tarla.Donum * _DonumBasinaEkipmanMaliyet;

                isci_masraf = Math.Round(isci_masraf, 2);

                textDiger.Text +=  "İşçi Masrafı" + Environment.NewLine + isci_masraf + " TL" + Environment.NewLine + Environment.NewLine;
                textDiger.Text += "Ekipman Masrafı" + Environment.NewLine + ekipman_masraf + " TL" + Environment.NewLine + Environment.NewLine;

               
                BtnToplamMaliyet.Text = "    TOPLAM" +
                Environment.NewLine + Environment.NewLine + (tarla.Maliyet+isci_masraf+ekipman_masraf)+ Environment.NewLine
                + Environment.NewLine + "TL";


                var isci_data = new { Name="İşçi", Maliyet= isci_masraf};
                var ekipman_data = new { Name = "ekipman", Maliyet = ekipman_masraf };


                list.Add(isci_data);
                list.Add(ekipman_data);
            }


            

            foreach (var item in list)
            {
                PieSeries pie = new PieSeries();
                pie.Title = item.Name;
                pie.Values = new ChartValues<double> { item.Maliyet };
                pie.DataLabels = true;
                
                
                series.Add(pie);
              
                pieChart1.Series = series;

                
            }
            
            //var list = new[] { ilac_data, mazot_data, gubre_data, tohum_data, diger_data }.ToList();

           


        }
        private bool firstCheckInfo;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           



            if (_tempTarla==null)
            {
                return;
            }
            DetailsShow(_tempTarla);


            if (!firstCheckInfo && datagridviewclik)
            {
                MessageBox.Show("İşçi ve EKipman ücretleri yıllık toplam şeklinde alınıyor. Tüm tarla verileri girilmeden işçilerin ve ekipmanların dönüm başına olan maliyetleirnin hesaplanması sağlıklı bir sonuç vermeyecektir. Tüm tarla bilgileri girildikten sonra işçi masraf kaleminin dönüm başına maliyeti kesin bir şekilde hesaplanacaktır.", "BİLGİLENDİRME", MessageBoxButtons.OK,MessageBoxIcon.Information);

                firstCheckInfo = true;
            }
        }
    }
}
