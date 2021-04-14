using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Projekt_Felulet
{
    public partial class Vendeg : Form
    {
        DB db = new DB();
        SQLiteCommand cmd;
        DataTable dt;
        SQLiteDataAdapter sda;

        public Vendeg()
        {
            InitializeComponent();
        }

        private void Vendeg_Load(object sender, EventArgs e)
        {
            /*cmd = new SQLiteCommand("Select * from etterem", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            db.closeconnection();*/
        }

        private void kilépésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rendszerfejlesztés korszerű módszerei - Online ételrendelés támogató rendszer");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("Select * from etterem", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            db.closeconnection();
        }
    }
}
