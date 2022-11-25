using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TarlaOtomasyonProjesi2.Entities;
namespace TarlaOtomasyonProjesi2.DAL
{
    public class Crud
    {

      

        public async Task AddAsync(Tarla tarla)
        {
            using (var db = new ApplicationDbContext())
            {
                await db.Tarlalar.AddAsync(tarla);
              await  db.SaveChangesAsync();
            }

        }
       

        public  async Task UpdateTarlaAsync(int id, Tarla tarla)
        {
            using (var db = new ApplicationDbContext())
            {
                var result = db.Tarlalar.Where(i => i.Id == id).First();
                if (result == null)
                {
                    MessageBox.Show("güncelleme Başarısız..");
                    return;


                }

                result.TarlaParselNo = tarla.TarlaParselNo;
                
                result.Donum = tarla.Donum;
                
                result.Maliyet = tarla.Maliyet;

                result.EkipmanMaliyet = tarla.EkipmanMaliyet;

                result.TohumKg = tarla.TohumKg;

                result.GubreKg = tarla.GubreKg;

                result.MatozLitre = tarla.MatozLitre;

                result.TohumKgBirimFiyat = tarla.TohumKgBirimFiyat;

                result.GubreKgBirimFiyat = tarla.GubreKgBirimFiyat;

                result.MatozLitreBirimFiyat = tarla.MatozLitreBirimFiyat;

                result.BicimMasrafTotal = tarla.BicimMasrafTotal;

                result.DigerNasraflar = tarla.DigerNasraflar;

                result.IlacEkim1Masraf = tarla.IlacEkim1Masraf;

                result.IlacEkim2masraf = tarla.IlacEkim2masraf;

                result.HolderlemeMasraf = tarla.HolderlemeMasraf;

                result.DigerIlacMasraf = tarla.DigerIlacMasraf;




              await  db.SaveChangesAsync();
              
            }
        }

        public async Task<List<Tarla>> GetAllDataAsync()
        {
            using (var db = new ApplicationDbContext())
            {
                var data= await db.Tarlalar.ToListAsync();
                return data;
            }
           
        }
        public  void Delete(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var result = db.Tarlalar.Where(i => i.Id == id).First();
                db.Tarlalar.Remove(result);
                db.SaveChanges();
            }
        }
        public Tarla GetDataById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var result = db.Tarlalar.Where(i => i.Id == id).FirstOrDefault();


                
                return result;
            }
        }



        public void IsciAdd(IsciTotalMasraf isci)
        {
            using (var db = new ApplicationDbContext())
            {
                db.IsciToplamUcret.Add(isci);
                db.SaveChanges();
            }
        }
        public void IsciUpdate(int ucret,double ekipman)
        {
            using (var db = new ApplicationDbContext())
            {
                var result =db.IsciToplamUcret.First();


                result.IsciToplamUcret = ucret;
                result.EkipmanMasrafYeniOzellik = ekipman;
                db.SaveChanges();

            }
        }
        public IsciTotalMasraf GetIsci()
        {
            int i = 1;
            IsciTotalMasraf isci = null;
            using (var db = new ApplicationDbContext())
            {
                isci = db.IsciToplamUcret.Where(a => a.Id == i).First();
                return isci;
            }
        }
    }
}

