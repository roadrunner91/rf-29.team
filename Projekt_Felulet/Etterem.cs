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
    public partial class Etterem : Form
    {
        DB db = new DB();
        SQLiteCommand cmd;
        DataTable dt;
        SQLiteDataAdapter sda;

        public Etterem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Etterem_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Etterem_regisztralas etterem_reg = new Etterem_regisztralas();
            this.Hide();
            etterem_reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etterem_Menu_felvitele etterem_menu = new Etterem_Menu_felvitele();
            this.Hide();
            etterem_menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etterem_etelek_rogzitese etterem_etelek = new Etterem_etelek_rogzitese();
            this.Hide();
            etterem_etelek.Show();
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
            cmd = new SQLiteCommand("Select elnevezes, kategoria, ar, szezon, kedvezmeny, allergen, elkeszitesiido from etel", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            db.closeconnection();
        }
    }
}
