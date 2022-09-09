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
    public partial class FrmSınavNotlar : Form
    {
        public FrmSınavNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IUJ388K;Initial Catalog=OkulProje;Integrated Security=True");
        DataSet1TableAdapters.notlarTableAdapter ds = new DataSet1TableAdapters.notlarTableAdapter();
        private void FrmSınavNotlar_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbders.DisplayMember = "dersad";
            cmbders.ValueMember = "dersid";
            cmbders.DataSource = dt;

            baglanti.Close();
         
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtogrid.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            txtogrid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void brnhesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, proje;
            double avg;
            string durum;

            s1 = Convert.ToInt16(txtsınav1.Text);
            s2 = Convert.ToInt16(txtsınav2.Text);
            s3 = Convert.ToInt16(txtsınav3.Text);
            proje = Convert.ToInt16(txtproje.Text);
            avg = (s1 + s2 + s3 + proje) / 4;
            txtortalama.Text = avg.ToString();
            
            if(avg >= 50)
            {
                txtdurum.Text = "True";

            }
            else
            {
                txtdurum.Text = "False";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
