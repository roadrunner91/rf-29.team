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
    public partial class Etterem_regisztralas : Form
    {
        public Etterem_regisztralas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etterem etterem = new Etterem();
            this.Hide();
            etterem.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("insert into etterem(elnevezes,nyitas,zaras,kulcsszo) values('" + text_nev.Text + "','" + Int32.Parse(text_nyitas.Text) + "','" + Int32.Parse(text_zaras.Text) + "','" + text_stilus.Text + "')", db.GetConnection());
            cmd.ExecuteNonQuery();
            db.closeconnection();
            text_nev.Text = "";
            text_nyitas.Text = "";
            text_zaras.Text = "";
            text_stilus.Text = "";
            textBox2.Text = "";
        }
    }
}
