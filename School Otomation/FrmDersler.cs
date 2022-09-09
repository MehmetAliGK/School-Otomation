using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRoje_Okul
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        void listele()
        {          
            dataGridView1.DataSource = ds.DersListesi();
       }

        DataSet1TableAdapters.derslerTableAdapter ds = new DataSet1TableAdapters.derslerTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {       
        listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource=ds.DersEkle(txtdersad.Text);
            MessageBox.Show("Ders eklendi.");
            listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtdersad.Text,byte.Parse(txtdersid.Text));
            MessageBox.Show("Ders güncellendi.");
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.derslerTableAdapter ds = new DataSet1TableAdapters.derslerTableAdapter();
            ds.DersSil(byte.Parse(txtdersid.Text));
            MessageBox.Show("Ders silindi.");
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtdersid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtdersad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
