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
    public partial class Etterem_etelek_rogzitese : Form
    {
        public Etterem_etelek_rogzitese()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| AllowDrop FIles(*.*) | *.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem megfelő a formátum");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etterem etterem = new Etterem();
            this.Hide();
            etterem.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("insert into etel(elnevezes, ar, allergen, leiras) values('" + textBox9.Text + "','" + textBox8.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", db.GetConnection());
            cmd.ExecuteNonQuery();
            db.closeconnection();
            textBox9.Text = "";
            textBox8.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
