using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Felulet
{
    public partial class Futar : Form
    {
        public Futar()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rendszerfejlesztés korszerű módszerei - Online ételrendelés támogató rendszer");
        }


        private void kilépésToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("insert into futar(datum) values('" + dateTimePicker1.Text + "')", db.GetConnection());
            cmd.ExecuteNonQuery();
            db.closeconnection();
            dateTimePicker1.Text = "";
        }
    }
}
