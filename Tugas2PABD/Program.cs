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
                    + "insert into Transaksi (Id_Transaksi,Kode_Transaksi,Tanggal_Transaksi) values('12125','AAAAB5','30-02-2022')"
                    
                    + "insert into Cake (Id_Cake,Nama_Cake,Harga,Stok) values('32121','Brownies','20000','7')"
                    + "insert into Cake (Id_Cake,Nama_Cake,Harga,Stok) values('32122','Bolu','10000','5')"
                    + "insert into Cake (Id_Cake,Nama_Cake,Harga,Stok) values('32123','Cheesecake','20000','6')"
                    + "insert into Cake (Id_Cake,Nama_Cake,Harga,Stok) values('32124','Tiramisu','25000','4')"
                    + "insert into Cake (Id_Cake,Nama_Cake,Harga,Stok) values('32125','BlackFor','40000','2')"

                    + "insert into Pembeli (Id_Pembeli,Nama_Pembeli,Jenis_Kelamin,No_Telp) values('40321','Zidan','L','08123123231')"
                    + "insert into Pembeli (Id_Pembeli,Nama_Pembeli,Jenis_Kelamin,No_Telp) values('40322','Saddin','L','08123123232')"
                    + "insert into Pembeli (Id_Pembeli,Nama_Pembeli,Jenis_Kelamin,No_Telp) values('40323','Nisa','P','08123123233')"
                    + "insert into Pembeli (Id_Pembeli,Nama_Pembeli,Jenis_Kelamin,No_Telp) values('40324','Reva','P','08123123234')"
                    + "insert into Pembeli (Id_Pembeli,Nama_Pembeli,Jenis_Kelamin,No_Telp) values('40325','Nazza','P','08123123235')"

                    + "insert into Menjual (Id_Kasir,Id_Cake,Id_Transaksi) values('212111','32121','12121')"
                    + "insert into Menjual (Id_Kasir,Id_Cake,Id_Transaksi) values('212112','32122','12122')"
                    + "insert into Menjual (Id_Kasir,Id_Cake,Id_Transaksi) values('212113','32123','12123')"
                    + "insert into Menjual (Id_Kasir,Id_Cake,Id_Transaksi) values('212114','32124','12124')"
                    + "insert into Menjual (Id_Kasir,Id_Cake,Id_Transaksi) values('212115','32125','12125')"

                    + "insert into Membeli (Id_Transaksi,Id_Pembeli,Id_Cake) values('12121','40321','32121')"
                    + "insert into Membeli (Id_Transaksi,Id_Pembeli,Id_Cake) values('12122','40322','32122')"
                    + "insert into Membeli (Id_Transaksi,Id_Pembeli,Id_Cake) values('12123','40323','32123')"
                    + "insert into Membeli (Id_Transaksi,Id_Pembeli,Id_Cake) values('12124','40324','32124')"
                    + "insert into Membeli (Id_Transaksi,Id_Pembeli,Id_Cake) values('12125','40325','32125')"

                    ,
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