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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
       
        void listele()
        {
            dataGridView1.DataSource = ds.OgrenciListele();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
        string c = "";
        private void btnekle_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
            if(radioButton2.Checked == true)
            {
                c = "Erkek";
            }
            dataGridView1.DataSource = ds.OgrenciEkle(txtograd.Text, txtogrsoyad.Text, byte.Parse(cmbkulüp.SelectedValue.ToString()),c);
            MessageBox.Show("Öğrenci Eklendi.");
            listele();
        }


        private void btnguncelle_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }

            ds.OgrenciGuncelle(txtograd.Text, txtogrsoyad.Text,byte.Parse(cmbkulüp.SelectedValue.ToString()),c,int.Parse(txtogrid.Text));
            MessageBox.Show("Öğrenci Güncellendi.");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;

            txtogrid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtograd.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtogrsoyad.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            cmbkulüp.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();

            if (dataGridView1.Rows[sec].Cells[3].Value.ToString() == "Kız")
            {
                radioButton1.Checked = true;
            }
            if (dataGridView1.Rows[sec].Cells[3].Value.ToString() == "Erkek")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtogrid.Text));
            MessageBox.Show("Öğrenci Silindi.");
            listele();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            listele();
           
            // display member,value member kullanımı
           
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IUJ388K;Initial Catalog=OkulProje;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from kulupler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);    
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            cmbkulüp.DisplayMember = "kulupad";
            cmbkulüp.ValueMember = "kulupid";
            cmbkulüp.DataSource = dt;
           
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciAra(txtara.Text);
            
        }
    }
}
