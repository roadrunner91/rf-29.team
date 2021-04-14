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
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        SQLiteDataAdapter sda;
        SQLiteCommand cmd = new SQLiteCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regisztralas Reg = new Regisztralas();
            this.Hide();
            Reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB dt2 = new DB();
            cmd = new SQLiteCommand("select count(*),szerepkor from felhadatok where felhnev='" + textBox1.Text + "' and jelszo='" + textBox2.Text + "'", dt2.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            string cmbitemvolue = comboBox1.SelectedItem.ToString();
            if (dt.Rows[0][0].ToString() == "1")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["szerepkor"].ToString() == cmbitemvolue)
                    {
                        MessageBox.Show("Beléptél " + dt.Rows[i]["szerepkor"] + "-ként");
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Vendeg vend = new Vendeg();
                            this.Hide();
                            vend.Show();
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            Futar futar = new Futar();
                            this.Hide();
                            futar.Show();
                        }
                        else
                        {
                            Etterem adm = new Etterem();
                            this.Hide();
                            adm.Show();
                        }
                    }
                    else
                        MessageBox.Show("Rossz szerepkörbe akartál belépni");
                }
            }
            else
            {
                MessageBox.Show("Rossz felhasználónév vagy jelszó");
            }
        }
    }
}
