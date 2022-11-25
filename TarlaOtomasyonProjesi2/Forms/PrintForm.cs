using IronPdf;
using System.Net;
using System.Net.Mail;
using TarlaOtomasyonProjesi2.DAL;
using TarlaOtomasyonProjesi2.Entities;

namespace TarlaOtomasyonProjesi2.Forms
{
    public partial class PrintForm : Form
    {
        private List<Tarla> _tarlalar;
        private string _Pdftext;
        private double _ToplamDonum;
        private string _pdfTextİsciVar;
        private string _pdfTextİsciYok;


        private int _isciMasraf;
        private double _ekipmaMasraf;
       
        public PrintForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

          

        }



        public void LoadingGiFClose()
        {
            panel1.Visible = false;
            panel1.SendToBack();
            BtnPrint.Enabled = true;
            checkBox1.Enabled = true;
            BtnMail.Enabled = true;
            BtnDbYedekAl.Enabled = true;
        
        }
        public void LoadingGiFOpen()
        {
            panel1.Visible = true;
            panel1.SendToBack();
            BtnPrint.Enabled = false;
            checkBox1.Enabled = false;
            BtnMail.Enabled = false;
            BtnDbYedekAl.Enabled = false;


        }
        private async void PrintForm_Load(object sender, EventArgs e)
        {

            lblTarih.Text = DateTime.Now.ToLongDateString();
            BtnPrint.Enabled = false;
            checkBox1.Enabled = false;
            BtnMail.Enabled = false;
            BtnDbYedekAl.Enabled = false;

            Globals.GlobalData.Status = false;

            #region data işlemleri

            var db = new Crud();

            var operation = Task.Run(() => db.GetAllDataAsync());


            _tarlalar = await operation;

            _isciMasraf = db.GetIsci().IsciToplamUcret;
            _ekipmaMasraf = db.GetIsci().EkipmanMasrafYeniOzellik;
            _tarlalar.ForEach(a => _ToplamDonum += a.Donum);

            if (_tarlalar == null)
            {
                MessageBox.Show("bir hata medyadana geldi tekrar deneyin");
                return;
            }


            dataGridView1.DataSource = _tarlalar;
            #endregion

            #region datagridview header names

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


            #endregion




            #region pdf text hazırlama

            var temp = "";
            #region işçi masrası yok
           
            foreach (var item in _tarlalar)
            {

                temp +=
                     "<p>" +
                         "Numaralı Tarla                : " + "<b> " + item.TarlaParselNo + " </b>" +
                         " Dönüm Boyutu :                " + "<b> " + item.Donum + " </b>" + "<br>" + "<br>" +
                         "1-) Kullanılan tohum   :      " + item.TohumKg + "KG'dir" + "<br>"+ "<br>" +
                         "2-) Tohum kilogram Fiyatı   :      " + item.TohumKgBirimFiyat + "TL'dir" + "<br>"+ "<br>" +
                         "<b> 3-) Toplam Tohum Masrafı   :      " + (item.TohumKg * item.TohumKgBirimFiyat) + "TL'dir </b>" + "<br>"+ "<br>" +
                        "<b> 4-) Dönüm Başına Tohum Masrafı   :      " + Math.Round(((item.TohumKg * item.TohumKgBirimFiyat) / (item.Donum)), 2).ToString() + "TL'dir </b>" + "<br>"+ "<br>" +


                         "5-) İlaç Ekim 1 Masrafı    :      " + item.IlacEkim1Masraf + "TL'dir" + "<br>" + "<br>" +
                         "6-) İlaç Ekim 2 Masrafı    :      " + item.IlacEkim2masraf + "TL'dir" + "<br>" + "<br>" +
                         "7-) Holderleme  Masrafı    :      " + item.HolderlemeMasraf + "TL'dir" + "<br>" + "<br>" +
                         "8-) Diğer İlaç Masrafları    :      " + item.DigerIlacMasraf + "TL'dir" + "<br>" + "<br>" +
                         "<b> 9-) Toplam İlaç Masrafları    :      " + (item.IlacEkim1Masraf + item.IlacEkim2masraf + item.HolderlemeMasraf + item.DigerIlacMasraf) + "TL'dir </b>" + "<br>" + "<br>" +
                         "<b> 10-) Dönüm Başına İlaç Masrafı    :      " + Math.Round(((item.IlacEkim1Masraf + item.IlacEkim2masraf + item.HolderlemeMasraf + item.DigerIlacMasraf) / (item.Donum)), 2) + "TL'dir </b>" + "<br>" + "<br>" +

                         "11-) Kullanılan Mazot   :      " + item.MatozLitre + " LT'dir" + "<br>" + "<br>" +
                         "12-) Mazot Litre Fiyatı Fiyatı   :      " + item.MatozLitreBirimFiyat + "TL'dir" + "<br>" + "<br>" +
                         "<b> 13-) Toplam Mazot Masrafı   :      " + Math.Round((item.MatozLitreBirimFiyat * item.MatozLitre),3) + " TL'dir </b>" + "<br>" + "<br> " +
                         "<b> 14-) Dönüm Başına Mazot Masrafı   :      " + Math.Round(((item.MatozLitreBirimFiyat * item.MatozLitre) / (item.Donum)), 2) + "TL'dir </b>" + "<br>" + "<br>" +


                         "15-) Kullanılan Gübre   :      " + item.GubreKg + "KG'dir" + "<br>" + "<br>" +
                         "16-) Gübre  Fiyatı Fiyatı   :      " + item.GubreKgBirimFiyat + "TL'dir" + "<br>" + "<br>" +
                         "<b> 17-) Toplam Gübre Masrafı   :      " + (item.GubreKgBirimFiyat * item.GubreKg) + " TL'dir </b> " + "<br>" + "<br>" +
                          "<b> 18-) Dönüm Başına Gübre Masrafı   :      " + Math.Round(((item.GubreKgBirimFiyat * item.GubreKg) / (item.Donum)), 2) + "TL'dir </b> " + "<br>" + "<br>" +

                         "<b> 19-) Biçim Masrafı   :      " + item.BicimMasrafTotal + "TL'dir </b>" + "<br>" + "<br>" +
                         "<b> 20-) Diğer Masraflar   :      " + (item.DigerNasraflar) + "TL'dir </b>" + "<br>" + "<br>" +
                         "<br>" + "<br>" +
                        "<b> 21-)  TOPLAM MASRAF   :     " + " <u>" + (item.Maliyet) + " </u> </b>" + "TL'dir </b>" + "<br>" + "<br>" + "<br>"+ "<br>" + "<br>"+ "<br>"
                        +"</p>" + "<p> <hr> </p>";




            }



            //TOPLAM MALİYET EKLEME

            temp += "<p> <hr> </p> <br> <br>"
                + "<h2> TOPLAM MALİYET <h2>";


            double _ToplamMazotFiyatMasraf=0;
            double _ToplamGubreMasraf = 0;
            double _ToplamTohumMasraf = 0;
            double _ToplamIlacMasraf = 0;
            double _ToplamDigerMAsraf = 0;
            double _ToplamBicimMasraf = 0;


            _tarlalar.ForEach(a => _ToplamMazotFiyatMasraf += (a.MatozLitreBirimFiyat * a.MatozLitre));
            _tarlalar.ForEach(a => _ToplamGubreMasraf += (a.GubreKgBirimFiyat * a.GubreKg));
            _tarlalar.ForEach(a => _ToplamTohumMasraf += (a.TohumKgBirimFiyat* a.TohumKg));
            _tarlalar.ForEach(a => _ToplamIlacMasraf += (a.IlacEkim1Masraf + a.IlacEkim2masraf+a.DigerIlacMasraf+a.HolderlemeMasraf));
            _tarlalar.ForEach(a => _ToplamDigerMAsraf += (a.BicimMasrafTotal+ a.EkipmanMaliyet + a.DigerNasraflar ));
            _tarlalar.ForEach(a => _ToplamBicimMasraf += (a.BicimMasrafTotal));

            var genel_toplam_isci_yok = _ToplamMazotFiyatMasraf+_ToplamGubreMasraf+_ToplamTohumMasraf+_ToplamIlacMasraf+_ToplamDigerMAsraf;

          

            temp += $"<h4> TOPLAM MAZOT MASRAFI ....................   {_ToplamMazotFiyatMasraf} TL </h4>";
            temp += $"<h4> TOPLAM GÜBRE MASRAFI ....................   {_ToplamGubreMasraf} TL </h4>";
            temp += $"<h4> TOPLAM TOHUM MASRAFI ....................    {_ToplamTohumMasraf} TL </h4>";
            temp += $"<h4> TOPLAM İLAÇ MASRAFI  ....................   {_ToplamIlacMasraf} TL </h4>";
            temp += $"<h4> TOPLAM DİĞER MASRAFLAR  ....................   {_ToplamDigerMAsraf} TL ({_ToplamBicimMasraf}) Biçim Dahil </h4>";
           
            temp += $"<br><br> <h3> <u> GENEL TOPLAM  ....................   {genel_toplam_isci_yok}  </u>  TL </h3> <br>";



            _pdfTextİsciYok = temp;






            #endregion

            temp = "";

            #region işçi masrafı var

           
            foreach (var item in _tarlalar)
            {

                temp +=

                        "<p>" +

                         "Numaralı Tarla                : " + "<b> " + item.TarlaParselNo + " </b>" +
                         " Dönüm Boyutu :                " + "<b> " + item.Donum + " </b>" + "<br>"+ "<br>" +
                         "1-) Kullanılan tohum   :      " + item.TohumKg + "KG'dir" + "<br>" + "<br>" +
                         "2-) Tohum kilogram Fiyatı   :      " + item.TohumKgBirimFiyat + "TL'dir" + "<br>" + "<br>" +
                         "<b> 3-) Toplam Tohum Masrafı   :      " + (item.TohumKg * item.TohumKgBirimFiyat) + "TL'dir </b>" + "<br>" + "<br>" +
                        "<b> 4-) Dönüm Başına Tohum Masrafı   :      " + Math.Round(((item.TohumKg * item.TohumKgBirimFiyat) / (item.Donum)), 2).ToString() + "TL'dir </b>" + "<br>" + "<br>" +


                         "5-) İlaç Ekim 1 Masrafı    :      " + item.IlacEkim1Masraf + "TL'dir" + "<br>" + "<br>" +
                         "6-) İlaç Ekim 2 Masrafı    :      " + item.IlacEkim2masraf + "TL'dir" + "<br>" + "<br>" +
                         "7-) Holderleme  Masrafı    :      " + item.HolderlemeMasraf + "TL'dir" + "<br>" + "<br>" +
                         "8-) Diğer İlaç Masrafları    :      " + item.DigerIlacMasraf + "TL'dir" + "<br>" + "<br>" +
                         "<b> 9-) Toplam İlaç Masrafları    :      " + (item.IlacEkim1Masraf + item.IlacEkim2masraf + item.HolderlemeMasraf + item.DigerIlacMasraf) + "TL'dir </b>" + "<br>" + "<br>" +
                         "<b> 10-) Dönüm Başına İlaç Masrafı    :      " + Math.Round(((item.IlacEkim1Masraf + item.IlacEkim2masraf + item.HolderlemeMasraf + item.DigerIlacMasraf) / (item.Donum)), 2) + "TL'dir </b>" + "<br>" + "<br>" +

                         "11-) Kullanılan Mazot   :      " + item.MatozLitre + "LT'dir" + "<br>" + "<br>" +
                         "12-) Mazot Litre Fiyatı Fiyatı   :      " + item.MatozLitreBirimFiyat + "TL'dir" + "<br>" + "<br>" +
                         "<b> 13-) Toplam Mazot Masrafı   :      " + Math.Round((item.MatozLitreBirimFiyat * item.MatozLitre),3) + "TL'dir </b>" + "<br>" + "<br> " +
                         "<b> 14-) Dönüm Başına Mazot Masrafı   :      " + Math.Round(((item.MatozLitreBirimFiyat * item.MatozLitre) / (item.Donum)), 2) + "TL'dir </b>" + "<br>" + "<br>" +


                         "15-) Kullanılan Gübre   :      " + item.GubreKg + "KG'dir" + "<br>" + "<br>" +
                         "16-) Gübre  Fiyatı Fiyatı   :      " + item.GubreKgBirimFiyat + "TL'dir" + "<br>" + "<br>" +
                         "<b> 17-) Toplam Gübre Masrafı   :      " + (item.GubreKgBirimFiyat * item.GubreKg) + "TL'dir </b> " + "<br>" + "<br>" +
                          "<b> 18-) Dönüm Başına Gübre Masrafı   :      " + Math.Round(((item.GubreKgBirimFiyat * item.GubreKg) / (item.Donum)), 2) + "TL'dir </b> " + "<br>" + "<br>" +

                         "<b> 19-) Biçim Masrafı   :      " + item.BicimMasrafTotal + "TL'dir </b> " + "<br>" + "<br>" +
                         "<b> 20-)" + item.Donum + " Dönüm Tarlanın Ekipman Masrafı    :" + Math.Round(((_ekipmaMasraf / _ToplamDonum) * item.Donum), 2) + "TL'dir </b>" + "<br>" + "<br>" +
                         "<b> 21-) Diğer Masraflar   :      " + item.DigerNasraflar +" TL'dir </b> " + "<br>" + "<br>" +
                         "<br>"  +
                         "<b> 22-)" + item.Donum + " Dönüm Tarlanın İşçi Masrafı    :" + Math.Round(((_isciMasraf / _ToplamDonum) * item.Donum), 2) + "TL'dir </b>" + "<br>" + "<br>" +
                           "<b> 23-)  TOPLAM MASRAF   :     <u> " + ((item.Maliyet) + Math.Round(((_isciMasraf / _ToplamDonum) * item.Donum), 2) + Math.Round(((_ekipmaMasraf / _ToplamDonum) * item.Donum), 2)) + "</u> </b> " + "TL'dir" + "<br>" + "<br>" +



                           "</p>" + "<p> <hr> </p>";





            }

            genel_toplam_isci_yok += _isciMasraf;
            genel_toplam_isci_yok += _ekipmaMasraf;

            temp += "<p> <hr> </p> <br> <br>"
               + "<h2> TOPLAM MALİYET <h2>";

            temp += $"<h4> TOPLAM MAZOT MASRAFI ....................   {_ToplamMazotFiyatMasraf} TL </h4>";
            temp += $"<h4> TOPLAM GÜBRE MASRAFI ....................   {_ToplamGubreMasraf} TL </h4>";
            temp += $"<h4> TOPLAM TOHUM MASRAFI ....................    {_ToplamTohumMasraf} TL </h4>";
            temp += $"<h4> TOPLAM İLAÇ MASRAFI  ....................   {_ToplamIlacMasraf} TL </h4>";
            temp += $"<h4> TOPLAM DİĞER MASRAFLAR  ....................   {_ToplamDigerMAsraf} TL bu tutarın {_ToplamBicimMasraf} TL'si biçim masrafı  </h4>";
            temp += $"<h4> TOPLAM İŞÇİ MASRAFI  ....................   {_isciMasraf} TL </h4>";
            temp += $"<h4> TOPLAM EKİPMAN MASRAFI  ....................   {_ekipmaMasraf} TL </h4>";


            temp += $"<br><br> <h3> <u> GENEL TOPLAM  ....................   {genel_toplam_isci_yok}  </u>  TL </h3> <br>";
            


            _pdfTextİsciVar = temp;

            #endregion




            #endregion






            //default
            _Pdftext = _pdfTextİsciYok;
            Globals.GlobalData.Status = true;
            LoadingGiFClose();

        }


        public void TextHazirla(bool status)
        {
            if (status)
            {
                _Pdftext = _pdfTextİsciVar;
            }
            else
            {
                _Pdftext = _pdfTextİsciYok;
            }
        }
    
        private void BtnPrint_Click(object sender, EventArgs e)
        {


          

            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog1.Title = "Dosya olusturma";
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                   
                   
                    string filename = saveFileDialog1.FileName;
                
                    var HtmlLine = new ChromePdfRenderer();
                    LoadingGiFOpen();
                    HtmlLine.RenderHtmlAsPdf(_Pdftext).SaveAs(filename);
                    LoadingGiFClose();
                    MessageBox.Show("dosya oluşturma başarılı");
                   

                }
            }
            catch (Exception)
            {

                MessageBox.Show("beklenmeyen bir hata oluştu ");
            }
            finally
            {
               
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("işçi ve ekipman maliyetleri eklendi");
                TextHazirla(true);
            }
            else
            {
                MessageBox.Show("işçi ve ekipman maliyetleri çıkarıldı");
                TextHazirla(false);
            }
        }

        private void BtnMail_Click(object sender, EventArgs e)
        {
            
            var result =YandexUzerinden();
            MessageBox.Show(result);
        }



       

        public static string YandexUzerinden()
        {
            

            SmtpClient sc = new SmtpClient("smtp.yandex.com.tr", 587);
           // sc.Port = 587;
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("MAİL ADRESİNİZ GİRİNİZ BU ALANA", "UYGULAMA ANAHATARI EDİNİN");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("MAİL ADRESİNİZ GİRİNİZ BU ALANA", "Tarla Gider Otomasyon Sistemi");
            mail.To.Add("MAİL ADRESİNİZ GİRİNİZ BU ALANA");
            mail.Subject = "Tarla Maliyet Verileri";
            mail.IsBodyHtml = true;
            mail.Body = DateTime.Now.ToString() + " Tarihinde tarla gider otomasyon üzerinde gönderilimiş bilgi mesajıdır. BAYSAL-Tech Otomasyon";

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf files |*.pdf";
            if (dosya.ShowDialog() == DialogResult.Cancel)
            {
               
                return "iptal edili";
            }
            var DosyaYolu = dosya.FileName;
            if (DosyaYolu != null)
            {
                mail.Attachments.Add(new Attachment(DosyaYolu));
            }
            //sc.Timeout = 200;
            try
            {

                DialogResult dialogResult = MessageBox.Show("Mail Gönderimini Onaylıyor musunuz", "Mail Gönderme", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    sc.Send(mail);
                    return "mail gönderme işlemi başarılı";
                }

                else
                {
                    return "iptal edildi";
                }
               
            }
            catch (Exception e)
            {

                return e.Message.ToString(); 
                
            }

        }

        private void BtnDbYedekAl_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Veri Tabanı Yedekleme İşlemini Onaylıyor musunuz", "Yedek Alma İşlemi", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

            try
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 99999);
                string sourceFile = System.Environment.CurrentDirectory + @"\TarlaDb.db";
                string destinationFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\VeriTabanıKopyası" + num.ToString() + ".db";
                File.Copy(sourceFile, destinationFile, true);

                    //mail göndrme işlemi yap

                    try
                    {
                        SmtpClient sc = new SmtpClient("smtp.yandex.com.tr", 587);
                        // sc.Port = 587;
                        sc.EnableSsl = true;
                        sc.Credentials = new NetworkCredential("MAİL ADRESİNİZ GİRİNİZ BU ALANA", "UYGULAMA ANAHATARI EDİNİN");

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("MAİL ADRESİNİZ GİRİNİZ BU ALANA", "Tarla Gider Otomasyon Sistemi");
                        mail.To.Add("MAİL ADRESİNİZ GİRİNİZ BU ALANA");
                        mail.Subject = "Tarla Maliyet Verileri";
                        mail.IsBodyHtml = true;
                        mail.Body = DateTime.Now.ToString() + " Tarihinde tarla gider otomasyon üzerinde gönderilimiş bilgi mesajıdır. BAYSAL-Tech Otomasyon";

                        //OpenFileDialog dosya = new OpenFileDialog();
                        //dosya.Filter = "Pdf files |*.pdf";

                        mail.Attachments.Add(new Attachment(destinationFile));
                        sc.Send(mail);
                       
                        //dosyayı sil
                        //başarılı yaz
                        MessageBox.Show("Yedekleme Başarılı. Masaütüne "+ "VeriTabanıKopyası" + num.ToString() + ".db  isimli bir dosya oluşturuldu"+Environment.NewLine
                            +"Dilerseniz programı KAPATTIKTAN ! sonra dosyayı silebilirsiniz Mail'e yedeklendi.","Yedekleme Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("başarısız");
                    }

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }

            }



            else
            {
                MessageBox.Show("yedekleme iptal edildi");
            }

        }
    }
}
