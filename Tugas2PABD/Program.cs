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

                SqlCommand cm = new SqlCommand("insert into Kasir (Id_Kasir,Nama_Karyawan,Jenis_Kelamin,No_Telp )values('212111','Nata','L','082121212111')", con);
                    
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