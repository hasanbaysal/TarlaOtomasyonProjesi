using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarlaOtomasyonProjesi2.Entities
{
    public  class Tarla
    {
        public int Id { get; set; } //0
        public string TarlaParselNo{ get; set; }//1
        public double Donum { get; set; }//2
        public double Maliyet { get; set; }// 3
        public double EkipmanMaliyet { get; set; }//4


        //maliyet kalemleri
        public double TohumKg { get; set; } //5
        public double GubreKg { get; set; } //6
      
        public double MatozLitre { get; set; }//7

        

        //birim
        public double TohumKgBirimFiyat { get; set; }//8
        public double GubreKgBirimFiyat { get; set; }//9
  
        public double MatozLitreBirimFiyat { get; set; }//10


        public double BicimMasrafTotal { get; set; }//11
        public double DigerNasraflar { get; set; }//12



        //ilaç masrafları 
        public double IlacEkim1Masraf{ get; set; }//13
        public double IlacEkim2masraf { get; set; }//14

        public double HolderlemeMasraf { get; set; }

        public double DigerIlacMasraf { get; set; }

    }
}
