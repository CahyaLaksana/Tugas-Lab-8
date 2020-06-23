using System;
using System.Collections.Generic;


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      
       
       KaryawanTetap karyawanTetap = new KaryawanTetap();
       karyawanTetap.NIK = "19-022";
       karyawanTetap.Nama = "Jason";
       karyawanTetap.GajiBulanan = 3200000;
       
       KaryawanHarian karyawanHarian = new KaryawanHarian();
       karyawanHarian.NIK = "19-045";
       karyawanHarian.Nama = "Freddy";
       karyawanHarian.UpahPerJam = 10000;
       karyawanHarian.JumlahJamKerja = 8;
       
       Sales sales = new Sales();
       sales.NIK = "11-991";
       sales.Nama = "Annable";
       sales.JumlahPenjualan = 15;
       sales.Komisi = 30000;
       
       List<Karyawan> karyawan = new List<Karyawan>();
       
       karyawan.Add(karyawanTetap);
       karyawan.Add(karyawanHarian);
       karyawan.Add(sales);
       
       
       Console.WriteLine("==================================================");
       Console.WriteLine(" NO | NIK / NAMA\t\t\t | Gaji\t\t |");
       Console.WriteLine("==================================================");
       for ( int i = 0; i < karyawan.Count; i++) {
         
            Console.WriteLine(" {0}. | {1} {2} \t\t\t| {3} \t |", i+1, karyawan[i].NIK, karyawan[i].Nama, karyawan[i].Gaji());
       }
       
       Console.ReadKey();
     }
   }
   
   public abstract class Karyawan {
     public string NIK;
     public string Nama;
     public abstract double Gaji();
   }
   
   public class KaryawanTetap : Karyawan {
     public double GajiBulanan;
     public override double Gaji() {
       return this.GajiBulanan;
     }
   }
   
   public class KaryawanHarian : Karyawan {
     public double UpahPerJam;
     public double JumlahJamKerja;
     public override double Gaji() {
       return this.UpahPerJam * this.JumlahJamKerja;
     }
   }
   
   public class Sales : Karyawan {
     public double JumlahPenjualan;
     public double Komisi;
     public override double Gaji() {
       return this.JumlahPenjualan * this.Komisi;
     }
   }
 }