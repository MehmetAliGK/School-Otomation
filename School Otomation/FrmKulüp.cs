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
    public partial class FrmKulüp : Form
    {
        public FrmKulüp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IUJ388K;Initial Catalog=OkulProje;Integrated Security=True");
      
       void listele()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from kulupler", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        
        private void FrmKulüp_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("insert into kulupler (kulupad) values (@a1)", baglanti);
            cmd2.Parameters.AddWithValue("@a1", txtkulupad.Text);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp eklendi.");
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtkulupid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtkulupad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("update kulupler set kulupad=@b1 where kulupid=@b2", baglanti);
            cmd2.Parameters.AddWithValue("@b1", txtkulupad.Text);
            cmd2.Parameters.AddWithValue("@b2", txtkulupid.Text);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp güncellendi.");
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("delete from kulupler where kulupid=@b2", baglanti);
            cmd2.Parameters.AddWithValue("@b1", txtkulupad.Text);
            cmd2.Parameters.AddWithValue("@b2", txtkulupid.Text);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp silindi.");
            listele();
        }
    }
}
