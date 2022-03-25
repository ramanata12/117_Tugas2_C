using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tugas2PABD
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();

        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = MSI;database=Bakery;User ID=sa;Password=12345678");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Kasir (Id_Kasir,Nama_Karyawan,Jenis_Kelamin,No_Telp )values('212111','Nata','L','082121212111')"
                    + "insert into Kasir (Id_Kasir,Nama_Karyawan,Jenis_Kelamin,No_Telp )values('212112','Ahmad','L','082121212113')"
                    + "insert into Kasir (Id_Kasir,Nama_Karyawan,Jenis_Kelamin,No_Telp )values('212113','Rahmad','L','082121212113')"
                    + "insert into Kasir (Id_Kasir,Nama_Karyawan,Jenis_Kelamin,No_Telp )values('212114','Nayah','P','082121212115')"
                    + "insert into Kasir (Id_Kasir,Nama_Karyawan,Jenis_Kelamin,No_Telp )values('212115','Nanda','P','082121212116')"

                    + "insert into Transaksi (Id_Transaksi,Kode_Transaksi,Tanggal_Transaksi) values('12121','AAAAB1','26-02-2022')"
                    + "insert into Transaksi (Id_Transaksi,Kode_Transaksi,Tanggal_Transaksi) values('12122','AAAAB2','27-02-2022')"
                    + "insert into Transaksi (Id_Transaksi,Kode_Transaksi,Tanggal_Transaksi) values('12123','AAAAB3','28-02-2022')"
                    + "insert into Transaksi (Id_Transaksi,Kode_Transaksi,Tanggal_Transaksi) values('12124','AAAAB4','29-02-2022')"
                    + "insert into Transaksi (Id_Transaksi,Kode_Transaksi,Tanggal_Transaksi) values('12125','AAAAB5','30-02-2022')",
                    con);
                    
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }

    }
}