using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    class sqlbaglantisi//sınıf adı
    {
        public SqlConnection baglanti()//metod adı
        {
            SqlConnection baglan = new SqlConnection("Data Source=TUNAHAN;Initial Catalog=HastaneProje;Integrated Security=True");//adresi tutan nesnenin adı
            baglan.Open();//metod
            return baglan;//geriye dönen değeri tutan kısım
        }
    }
}
