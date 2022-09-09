using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PRoje_Okul
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IUJ388K;Initial Catalog=OkulProje;Integrated Security=True");
        public string id;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from notlar where ogrid=@a1", baglanti) ;
            cmd.Parameters.AddWithValue("@a1", id);            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);          
            dataGridView1.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select (ograd+ogrsoyad) from ogrenciler where ogrid= @b1",baglanti);
            cmd2.Parameters.AddWithValue("@b1", id);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select dersad,sinav1,sinav2,sinav3,ortalama,proje,durum from notlar inner join dersler on notlar.dersid=dersler.dersid where ogrid = @c1", baglanti);
            cmd3.Parameters.AddWithValue("@c1", id);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource=dt1;
            baglanti.Close();


        }
    }
}
