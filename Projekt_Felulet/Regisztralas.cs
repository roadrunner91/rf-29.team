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
    public partial class Regisztralas : Form
    {
        public Regisztralas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "Megadott jelszó: " + text_jelszo.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fold = new Form1();
            this.Hide();
            fold.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("insert into felhadatok(felhnev,jelszo,szerepkor,vezeteknev,keresztnev) values('" + text_felhnev.Text + "','" + text_jelszo.Text + "','" + comboBox1.Text + "','" + text_veznev.Text + "','" + text_kernev.Text + "')", db.GetConnection());
            cmd.ExecuteNonQuery();
            db.closeconnection();
            text_jelszo.Text = "";
            text_felhnev.Text = "";
            text_kernev.Text = "";
            text_veznev.Text = "";
        }
    }
}
