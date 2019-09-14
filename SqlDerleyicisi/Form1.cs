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

namespace SqlDerleyicisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDerle_Click(object sender, EventArgs e)
        {
            string sorgu;
            sorgu = rchDerle.Text;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Sorgu!!!", "UYARII!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void ABOUT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NORTHWIND VERI TABANI KULLANILARAK YAPILMIŞTIR...", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
